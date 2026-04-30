using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace prySP2chiavetta
{
    public partial class FrmCantante : Form
    {
        // Cadena de conexión a la base de datos
        
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\BasedeDatos\\academia.accdb;";
        //private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\BasedeDatos\\academia.mdb;";

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

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Verificar si el número ya existe
                    string queryCheck = "SELECT COUNT(*) FROM [Cantantes] WHERE [idCantante] = ?";
                    using (OleDbCommand cmdCheck = new OleDbCommand(queryCheck, conn))
                    {
                        // For OleDb use positional parameters ("?") and provide values in order
                        cmdCheck.Parameters.Add("?", OleDbType.Integer).Value = numero;
                        object result = cmdCheck.ExecuteScalar();
                        int count = Convert.ToInt32(result ?? 0);

                        if (count > 0)
                        {
                            MessageBox.Show("Ya existe un cantante con ese número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insertar nuevo cantante
                    string queryInsert = "INSERT INTO [Cantantes] ([idCantante], [Nombre]) VALUES (?, ?)";
                    using (OleDbCommand cmdInsert = new OleDbCommand(queryInsert, conn))
                    {
                        cmdInsert.Parameters.Add("?", OleDbType.Integer).Value = numero;
                        cmdInsert.Parameters.Add("?", OleDbType.VarWChar).Value = txtNombreCantante.Text.Trim();
                        cmdInsert.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cantante guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar campos
                txtNumeroCantante.Clear();
                txtNombreCantante.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCantante_Load(object sender, EventArgs e)
        {

        }
    }
}
