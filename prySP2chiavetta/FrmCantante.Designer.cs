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
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Cantante";
            // 
            // txtNumeroCantante
            // 
            this.txtNumeroCantante.Location = new System.Drawing.Point(33, 50);
            this.txtNumeroCantante.Name = "txtNumeroCantante";
            this.txtNumeroCantante.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroCantante.TabIndex = 1;
            this.txtNumeroCantante.TextChanged += new System.EventHandler(this.txtNumeroCantante_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Cantante";
            // 
            // txtNombreCantante
            // 
            this.txtNombreCantante.Location = new System.Drawing.Point(33, 110);
            this.txtNombreCantante.Name = "txtNombreCantante";
            this.txtNombreCantante.Size = new System.Drawing.Size(300, 20);
            this.txtNombreCantante.TabIndex = 3;
            this.txtNombreCantante.TextChanged += new System.EventHandler(this.txtNombreCantante_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(33, 150);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmCantante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 220);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreCantante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroCantante);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
