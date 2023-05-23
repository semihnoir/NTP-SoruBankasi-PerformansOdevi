namespace performans
{
    partial class KayitOl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelGiris = new System.Windows.Forms.LinkLabel();
            this.buttonKayit = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::performans.Properties.Resources._154345;
            this.pictureBox1.Location = new System.Drawing.Point(122, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelGiris
            // 
            this.linkLabelGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelGiris.Font = new System.Drawing.Font("TRT Medium", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGiris.Location = new System.Drawing.Point(69, 253);
            this.linkLabelGiris.Name = "linkLabelGiris";
            this.linkLabelGiris.Size = new System.Drawing.Size(206, 25);
            this.linkLabelGiris.TabIndex = 12;
            this.linkLabelGiris.TabStop = true;
            this.linkLabelGiris.Text = "Hesabınız Var Mı? Giriş Yap";
            this.linkLabelGiris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGiris_LinkClicked);
            // 
            // buttonKayit
            // 
            this.buttonKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKayit.Location = new System.Drawing.Point(123, 195);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(99, 38);
            this.buttonKayit.TabIndex = 11;
            this.buttonKayit.Text = "Kayıt Ol";
            this.buttonKayit.UseVisualStyleBackColor = true;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(168, 149);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(111, 28);
            this.textBoxPass.TabIndex = 10;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre";
            // 
            // textBoxKA
            // 
            this.textBoxKA.Location = new System.Drawing.Point(168, 115);
            this.textBoxKA.Name = "textBoxKA";
            this.textBoxKA.Size = new System.Drawing.Size(111, 28);
            this.textBoxKA.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 302);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelGiris);
            this.Controls.Add(this.buttonKayit);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("TRT Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "KayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KayitOl_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelGiris;
        private System.Windows.Forms.Button buttonKayit;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKA;
        private System.Windows.Forms.Label label1;
    }
}