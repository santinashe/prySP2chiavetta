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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerVideo));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCantantes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTemas = new System.Windows.Forms.ComboBox();
            this.btnVerVideo = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCantantes
            // 
            this.cmbCantantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantantes.FormattingEnabled = true;
            this.cmbCantantes.Location = new System.Drawing.Point(43, 61);
            this.cmbCantantes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbCantantes.Name = "cmbCantantes";
            this.cmbCantantes.Size = new System.Drawing.Size(547, 28);
            this.cmbCantantes.TabIndex = 1;
            this.cmbCantantes.SelectedIndexChanged += new System.EventHandler(this.cmbCantantes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tema";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbTemas
            // 
            this.cmbTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemas.FormattingEnabled = true;
            this.cmbTemas.Location = new System.Drawing.Point(43, 154);
            this.cmbTemas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbTemas.Name = "cmbTemas";
            this.cmbTemas.Size = new System.Drawing.Size(547, 28);
            this.cmbTemas.TabIndex = 3;
            // 
            // btnVerVideo
            // 
            this.btnVerVideo.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnVerVideo.BackgroundImage = global::prySP2chiavetta.Properties.Resources.ChatGPT_Image_12_may_2026__05_52_24_p_m_;
            this.btnVerVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVideo.ForeColor = System.Drawing.Color.Tomato;
            this.btnVerVideo.Location = new System.Drawing.Point(43, 215);
            this.btnVerVideo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnVerVideo.Name = "btnVerVideo";
            this.btnVerVideo.Size = new System.Drawing.Size(183, 46);
            this.btnVerVideo.TabIndex = 4;
            this.btnVerVideo.Text = "Ver Video";
            this.btnVerVideo.UseVisualStyleBackColor = false;
            this.btnVerVideo.Click += new System.EventHandler(this.btnVerVideo_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(611, 41);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(37, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1100, 615);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prySP2chiavetta.Properties.Resources.ChatGPT_Image_12_may_2026__05_52_24_p_m_;
            this.pictureBox1.Location = new System.Drawing.Point(41, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVerVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1797, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnVerVideo);
            this.Controls.Add(this.cmbTemas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCantantes);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ver Video Tema";
            this.Load += new System.EventHandler(this.FrmVerVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCantantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTemas;
        private System.Windows.Forms.Button btnVerVideo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
