namespace prySP2chiavetta
{
    partial class FrmCantante
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantante));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroCantante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCantante = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Cantante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumeroCantante
            // 
            this.txtNumeroCantante.Location = new System.Drawing.Point(43, 94);
            this.txtNumeroCantante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroCantante.Name = "txtNumeroCantante";
            this.txtNumeroCantante.Size = new System.Drawing.Size(271, 22);
            this.txtNumeroCantante.TabIndex = 1;
            this.txtNumeroCantante.TextChanged += new System.EventHandler(this.txtNumeroCantante_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Cantante";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombreCantante
            // 
            this.txtNombreCantante.Location = new System.Drawing.Point(43, 164);
            this.txtNombreCantante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCantante.Name = "txtNombreCantante";
            this.txtNombreCantante.Size = new System.Drawing.Size(405, 22);
            this.txtNombreCantante.TabIndex = 3;
            this.txtNombreCantante.TextChanged += new System.EventHandler(this.txtNombreCantante_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(173, 385);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(176, 49);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmCantante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySP2chiavetta.Properties.Resources.ChatGPT_Image_12_may_2026__05_52_24_p_m_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(534, 447);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreCantante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroCantante);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCantante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Cantante";
            this.Load += new System.EventHandler(this.FrmCantante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroCantante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCantante;
        private System.Windows.Forms.Button btnGuardar;
    }
}
