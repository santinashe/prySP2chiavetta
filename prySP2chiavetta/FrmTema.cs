using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace prySP2chiavetta
{
    public partial class FrmTema : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\basededatos\\Academia.mdb;";

        public FrmTema()
        {
            InitializeComponent();
        }

        private void FrmTema_Load(object sender, EventArgs e)
        {
            CargarCantantes();
        }

        // Cargar cantantes en el combo
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar numérico
            if (!int.TryParse(txtNumeroTema.Text.Trim(), out int numeroTema))
            {
                MessageBox.Show("El número de tema debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNombreTema.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del tema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCantantes.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cantante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numeroCantante = Convert.ToInt32(cmbCantantes.SelectedValue);

            OleDbConnection conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                // Verificar duplicado
                string queryCheck = "SELECT COUNT(*) FROM Temas WHERE NumeroTema = ?";
                OleDbCommand cmdCheck = new OleDbCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@NumeroTema", numeroTema);
                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Ya existe un tema con ese número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insertar
                string queryInsert = "INSERT INTO Temas (NumeroTema, NombreTema, URLVideo, NumeroCantante) VALUES (?, ?, ?, ?)";
                OleDbCommand cmdInsert = new OleDbCommand(queryInsert, conn);
                cmdInsert.Parameters.AddWithValue("@NumeroTema", numeroTema);
                cmdInsert.Parameters.AddWithValue("@NombreTema", txtNombreTema.Text.Trim());
                cmdInsert.Parameters.AddWithValue("@URLVideo", txtURL.Text.Trim());
                cmdInsert.Parameters.AddWithValue("@NumeroCantante", numeroCantante);
                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Tema guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar
                txtNumeroTema.Clear();
                txtNombreTema.Clear();
                txtURL.Clear();
                cmbCantantes.SelectedIndex = -1;
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
