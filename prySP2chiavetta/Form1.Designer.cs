namespace prySP2chiavetta
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cantantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCantanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVideoTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantantesToolStripMenuItem,
            this.temasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cantantesToolStripMenuItem
            // 
            this.cantantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCantanteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.cantantesToolStripMenuItem.Name = "cantantesToolStripMenuItem";
            this.cantantesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.cantantesToolStripMenuItem.Text = "Cantantes";
            // 
            // nuevoCantanteToolStripMenuItem
            // 
            this.nuevoCantanteToolStripMenuItem.Name = "nuevoCantanteToolStripMenuItem";
            this.nuevoCantanteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nuevoCantanteToolStripMenuItem.Text = "Nuevo Cantante";
            this.nuevoCantanteToolStripMenuItem.Click += new System.EventHandler(this.nuevoCantanteToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // temasToolStripMenuItem
            // 
            this.temasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTemaToolStripMenuItem,
            this.verVideoTemaToolStripMenuItem});
            this.temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            this.temasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.temasToolStripMenuItem.Text = "Temas";
            // 
            // nuevoTemaToolStripMenuItem
            // 
            this.nuevoTemaToolStripMenuItem.Name = "nuevoTemaToolStripMenuItem";
            this.nuevoTemaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.nuevoTemaToolStripMenuItem.Text = "Nuevo Tema";
            this.nuevoTemaToolStripMenuItem.Click += new System.EventHandler(this.nuevoTemaToolStripMenuItem_Click);
            // 
            // verVideoTemaToolStripMenuItem
            // 
            this.verVideoTemaToolStripMenuItem.Name = "verVideoTemaToolStripMenuItem";
            this.verVideoTemaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.verVideoTemaToolStripMenuItem.Text = "Ver Video Tema";
            this.verVideoTemaToolStripMenuItem.Click += new System.EventHandler(this.verVideoTemaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACADEMIA DE MÚSICA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(0, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aplicación para gestionar videos de temas musicales";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia de Música";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cantantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoCantanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verVideoTemaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

