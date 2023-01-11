namespace performans
{
    partial class SoruSil
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
            this.listBoxSorular = new System.Windows.Forms.ListBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxSorular
            // 
            this.listBoxSorular.FormattingEnabled = true;
            this.listBoxSorular.Location = new System.Drawing.Point(32, 57);
            this.listBoxSorular.Name = "listBoxSorular";
            this.listBoxSorular.Size = new System.Drawing.Size(199, 147);
            this.listBoxSorular.TabIndex = 0;
            this.listBoxSorular.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonSil
            // 
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSil.Font = new System.Drawing.Font("TRT Medium", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(70, 239);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(122, 36);
            this.buttonSil.TabIndex = 1;
            this.buttonSil.Text = "Seçilen Soruyu Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TRT Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silmek İstediğiniz Soruyu Seçiniz";
            // 
            // textBoxSil
            // 
            this.textBoxSil.Font = new System.Drawing.Font("TRT Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSil.Location = new System.Drawing.Point(32, 210);
            this.textBoxSil.Name = "textBoxSil";
            this.textBoxSil.Size = new System.Drawing.Size(199, 23);
            this.textBoxSil.TabIndex = 3;
            // 
            // SoruSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 303);
            this.Controls.Add(this.textBoxSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.listBoxSorular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SoruSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soru Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSil;
        public System.Windows.Forms.ListBox listBoxSorular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSil;
    }
}