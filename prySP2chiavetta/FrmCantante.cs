using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace prySP2chiavetta
{
    public partial class FrmCantante : Form
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\basededatos\\Academia.mdb;";

        public FrmCantante()
        {
            InitializeComponent();
            btnGuardar.Enabled = false; // botón deshabilitado inicialmente
        }

        // Validar que los campos tengan datos y activar btnGuardar
        private void txtNumeroCantante_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtNombreCantante_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void ValidarCampos()
        {
            // Habilitar el botón solo si ambos campos no están vacíos
            btnGuardar.Enabled = txtNumeroCantante.Text.Trim() != "" && txtNombreCantante.Text.Trim() != "";
        }

        // Evento clic guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que el número sea numérico
            if (!int.TryParse(txtNumeroCantante.Text.Trim(), out int numero))
            {
                MessageBox.Show("El número de cantante debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OleDbConnection conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                // Verificar si el número ya existe
                string queryCheck = "SELECT COUNT(*) FROM Cantantes WHERE NumeroCantante = ?";
                OleDbCommand cmdCheck = new OleDbCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@NumeroCantante", numero);
                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Ya existe un cantante con ese número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insertar nuevo cantante
                string queryInsert = "INSERT INTO Cantantes (NumeroCantante, NombreCantante) VALUES (?, ?)";
                OleDbCommand cmdInsert = new OleDbCommand(queryInsert, conn);
                cmdInsert.Parameters.AddWithValue("@NumeroCantante", numero);
                cmdInsert.Parameters.AddWithValue("@NombreCantante", txtNombreCantante.Text.Trim());
                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Cantante guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar campos
                txtNumeroCantante.Clear();
                txtNombreCantante.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar conexión siempre
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
