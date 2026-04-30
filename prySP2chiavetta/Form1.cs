using System;
using System.Windows.Forms;

namespace prySP2chiavetta
{
    // FrmPrincipal - formulario principal renombrado desde Form1
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // Abrir formulario Nuevo Cantante
        private void nuevoCantanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCantante frm = new FrmCantante();
            frm.ShowDialog();
        }

        // Salir de la aplicación
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Abrir formulario Nuevo Tema
        private void nuevoTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTema frm = new FrmTema();
            frm.ShowDialog();
        }

        // Abrir formulario Ver Video Tema
        private void verVideoTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerVideo frm = new FrmVerVideo();
            frm.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
