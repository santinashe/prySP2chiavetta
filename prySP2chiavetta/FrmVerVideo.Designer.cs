namespace prySP2chiavetta
{
    partial class FrmVerVideo
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
            this.cmbCantantes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTemas = new System.Windows.Forms.ComboBox();
            this.btnVerVideo = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantante";
            // 
            // cmbCantantes
            // 
            this.cmbCantantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantantes.FormattingEnabled = true;
            this.cmbCantantes.Location = new System.Drawing.Point(23, 40);
            this.cmbCantantes.Name = "cmbCantantes";
            this.cmbCantantes.Size = new System.Drawing.Size(300, 24);
            this.cmbCantantes.TabIndex = 1;
            this.cmbCantantes.SelectedIndexChanged += new System.EventHandler(this.cmbCantantes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tema";
            // 
            // cmbTemas
            // 
            this.cmbTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemas.FormattingEnabled = true;
            this.cmbTemas.Location = new System.Drawing.Point(23, 100);
            this.cmbTemas.Name = "cmbTemas";
            this.cmbTemas.Size = new System.Drawing.Size(300, 24);
            this.cmbTemas.TabIndex = 3;
            // 
            // btnVerVideo
            // 
            this.btnVerVideo.Location = new System.Drawing.Point(23, 140);
            this.btnVerVideo.Name = "btnVerVideo";
            this.btnVerVideo.Size = new System.Drawing.Size(100, 30);
            this.btnVerVideo.TabIndex = 4;
            this.btnVerVideo.Text = "Ver Video";
            this.btnVerVideo.UseVisualStyleBackColor = true;
            this.btnVerVideo.Click += new System.EventHandler(this.btnVerVideo_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(350, 20);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(600, 400);
            this.webBrowser1.TabIndex = 5;
            // 
            // FrmVerVideo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnVerVideo);
            this.Controls.Add(this.cmbTemas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCantantes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ver Video Tema";
            this.Load += new System.EventHandler(this.FrmVerVideo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCantantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTemas;
        private System.Windows.Forms.Button btnVerVideo;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
