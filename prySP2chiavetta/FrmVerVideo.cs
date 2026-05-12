using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace prySP2chiavetta
{
    public partial class FrmVerVideo : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\BasedeDatos\\academia.accdb;";
        // pending video id to embed when the document is ready
        private string pendingVideoId = null;

        public FrmVerVideo()
        {
            InitializeComponent();
            // Evitar que aparezcan diálogos de errores de script del control WebBrowser
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void FrmVerVideo_Load(object sender, EventArgs e)
        {
            CargarCantantes();
        }

        private void CargarCantantes()
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT idCantante, Nombre FROM Cantantes";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbCantantes.DisplayMember = "Nombre";
                cmbCantantes.ValueMember = "idCantante";
                cmbCantantes.DataSource = dt;
                cmbCantantes.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar cantantes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void cmbCantantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTemas();
        }

        private void CargarTemas()
        {
            if (cmbCantantes.SelectedValue == null) return;
            int numeroCantante = Convert.ToInt32(cmbCantantes.SelectedValue);
            OleDbConnection conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT idTema, Nombre FROM Temas WHERE idCantante = ?";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@idCantante", numeroCantante);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbTemas.DisplayMember = "Nombre";
                cmbTemas.ValueMember = "idTema";
                cmbTemas.DataSource = dt;
                cmbTemas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar temas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnVerVideo_Click(object sender, EventArgs e)
        {
            if (cmbTemas.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un tema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numeroTema = Convert.ToInt32(cmbTemas.SelectedValue);
            OleDbConnection conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT link FROM Temas WHERE idTema = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@idTema", numeroTema);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    string url = result.ToString();

                    // Intentamos extraer el id y embebemos el iframe dentro del WebBrowser.
                    string videoId = ExtractYouTubeVideoId(url);
                    if (!string.IsNullOrEmpty(videoId))
                    {
                        // Guardar el id y navegar a about:blank para preparar el documento
                        pendingVideoId = videoId;
                        webBrowser1.Navigate("about:blank");
                        return;
                    }

                    // Si no es YouTube o no se pudo extraer, navegar normalmente
                    webBrowser1.Navigate(url);
                }
                else
                {
                    MessageBox.Show("El tema no tiene una URL guardada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // Extrae el ID del video de distintos tipos de URLs de YouTube (watch, youtu.be, shorts, embed)
        private string ExtractYouTubeVideoId(string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return null;

            try
            {
                // patrones comunes
                // https://www.youtube.com/watch?v=VIDEOID
                // https://m.youtube.com/watch?v=VIDEOID
                // https://youtu.be/VIDEOID
                // https://www.youtube.com/shorts/VIDEOID
                // https://www.youtube.com/embed/VIDEOID

                // Primero buscar v= param
                var m = Regex.Match(url, "[?&]v=([a-zA-Z0-9_-]{11})");
                if (m.Success) return m.Groups[1].Value;

                // youtu.be/VIDEOID or /embed/VIDEOID or /shorts/VIDEOID
                m = Regex.Match(url, @"(?:youtu\.be/|/embed/|/shorts/)([a-zA-Z0-9_-]{11})");
                if (m.Success) return m.Groups[1].Value;

                // As fallback try to extract last 11-char segment
                m = Regex.Match(url, "([a-zA-Z0-9_-]{11})$");
                if (m.Success) return m.Groups[1].Value;
            }
            catch
            {
                // ignore
            }

            return null;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Inyectar iframe solo cuando about:blank haya terminado de cargarse
            if (!string.IsNullOrEmpty(pendingVideoId) && e.Url != null && e.Url.AbsoluteUri == "about:blank")
            {
                try
                {
                    string html = $"<!DOCTYPE html><html><head><meta http-equiv='X-UA-Compatible' content='IE=edge' /><meta charset='utf-8' /><style>html,body,#player{{width:100%;height:100%;margin:0;padding:0;background:black;}}iframe{{width:100%;height:100%;border:0;}}</style></head><body><div id='player'><iframe src='https://www.youtube-nocookie.com/embed/{pendingVideoId}?rel=0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe></div></body></html>";
                    if (webBrowser1.Document != null)
                    {
                        // Reemplazar el documento mediante Document.OpenNew/Write para forzar carga correcta
                        webBrowser1.Document.OpenNew(true);
                        webBrowser1.Document.Write(html);
                    }
                    else
                    {
                        webBrowser1.DocumentText = html;
                    }
                }
                catch
                {
                    // Ignorar errores y no bloquear la UI
                }
                finally
                {
                    // Limpiar para que no vuelva a reinyectar
                    pendingVideoId = null;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
