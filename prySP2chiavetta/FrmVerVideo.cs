using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace prySP2chiavetta
{
    public partial class FrmVerVideo : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\basededatos\\Academia.mdb;";

        public FrmVerVideo()
        {
            InitializeComponent();
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
                string query = "SELECT NumeroCantante, NombreCantante FROM Cantantes";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbCantantes.DisplayMember = "NombreCantante";
                cmbCantantes.ValueMember = "NumeroCantante";
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
                string query = "SELECT NumeroTema, NombreTema FROM Temas WHERE NumeroCantante = ?";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@NumeroCantante", numeroCantante);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbTemas.DisplayMember = "NombreTema";
                cmbTemas.ValueMember = "NumeroTema";
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
                string query = "SELECT URLVideo FROM Temas WHERE NumeroTema = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@NumeroTema", numeroTema);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    string url = result.ToString();
                    try
                    {
                        webBrowser1.Navigate(url);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo navegar a la URL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
    }
}
