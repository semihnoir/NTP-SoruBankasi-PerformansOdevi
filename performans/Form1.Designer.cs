namespace performans
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnTemizleCevaplar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.btnTemizleMetin = new System.Windows.Forms.Button();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.richTextBoxSoru = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDersler = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSorular = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblDers = new System.Windows.Forms.Label();
            this.soruSayisiN = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelSorular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soruSayisiN)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 319);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.soruSayisiN);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnOlustur);
            this.tabPage1.Controls.Add(this.btnTemizleCevaplar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnTemizleMetin);
            this.tabPage1.Controls.Add(this.btnSoruEkle);
            this.tabPage1.Controls.Add(this.richTextBoxSoru);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxDersler);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Soru Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Soru Metni";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOlustur.Location = new System.Drawing.Point(214, 246);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(98, 31);
            this.btnOlustur.TabIndex = 21;
            this.btnOlustur.Text = "Test Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnTemizleCevaplar
            // 
            this.btnTemizleCevaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizleCevaplar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizleCevaplar.Location = new System.Drawing.Point(308, 202);
            this.btnTemizleCevaplar.Name = "btnTemizleCevaplar";
            this.btnTemizleCevaplar.Size = new System.Drawing.Size(130, 28);
            this.btnTemizleCevaplar.TabIndex = 20;
            this.btnTemizleCevaplar.Text = "Cevapları Temizle";
            this.btnTemizleCevaplar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.radioButtonC);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.radioButtonB);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButtonA);
            this.groupBox1.Location = new System.Drawing.Point(308, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 182);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cevaplar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(100, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cevap";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru\r\nCevap";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 145);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 28);
            this.textBox3.TabIndex = 5;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(4, 149);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(34, 19);
            this.radioButtonC.TabIndex = 4;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 102);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 28);
            this.textBox2.TabIndex = 3;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(4, 106);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(34, 19);
            this.radioButtonB.TabIndex = 2;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 28);
            this.textBox1.TabIndex = 1;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(4, 60);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(33, 19);
            this.radioButtonA.TabIndex = 0;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // btnTemizleMetin
            // 
            this.btnTemizleMetin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizleMetin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizleMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizleMetin.Location = new System.Drawing.Point(151, 44);
            this.btnTemizleMetin.Name = "btnTemizleMetin";
            this.btnTemizleMetin.Size = new System.Drawing.Size(103, 29);
            this.btnTemizleMetin.TabIndex = 18;
            this.btnTemizleMetin.Text = "Metni Temizle";
            this.btnTemizleMetin.UseVisualStyleBackColor = true;
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoruEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSoruEkle.Location = new System.Drawing.Point(444, 202);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(82, 28);
            this.btnSoruEkle.TabIndex = 17;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = true;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // richTextBoxSoru
            // 
            this.richTextBoxSoru.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxSoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxSoru.Location = new System.Drawing.Point(29, 85);
            this.richTextBoxSoru.Name = "richTextBoxSoru";
            this.richTextBoxSoru.Size = new System.Drawing.Size(225, 130);
            this.richTextBoxSoru.TabIndex = 16;
            this.richTextBoxSoru.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ders";
            // 
            // comboBoxDersler
            // 
            this.comboBoxDersler.FormattingEnabled = true;
            this.comboBoxDersler.Items.AddRange(new object[] {
            "Matematik",
            "Fizik",
            "Programlama"});
            this.comboBoxDersler.Location = new System.Drawing.Point(65, 14);
            this.comboBoxDersler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDersler.Name = "comboBoxDersler";
            this.comboBoxDersler.Size = new System.Drawing.Size(189, 23);
            this.comboBoxDersler.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panelSorular);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sorular";
            // 
            // panelSorular
            // 
            this.panelSorular.Controls.Add(this.listBox1);
            this.panelSorular.Controls.Add(this.lblDers);
            this.panelSorular.Location = new System.Drawing.Point(3, 3);
            this.panelSorular.Name = "panelSorular";
            this.panelSorular.Size = new System.Drawing.Size(546, 284);
            this.panelSorular.TabIndex = 0;
            this.panelSorular.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(27, 45);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 199);
            this.listBox1.TabIndex = 29;
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Location = new System.Drawing.Point(25, 24);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(45, 15);
            this.lblDers.TabIndex = 28;
            this.lblDers.Text = "Ders: ";
            // 
            // soruSayisiN
            // 
            this.soruSayisiN.Location = new System.Drawing.Point(111, 221);
            this.soruSayisiN.Name = "soruSayisiN";
            this.soruSayisiN.Size = new System.Drawing.Size(38, 21);
            this.soruSayisiN.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Soru Sayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 320);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soru Bankası";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelSorular.ResumeLayout(false);
            this.panelSorular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soruSayisiN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnTemizleCevaplar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.Button btnTemizleMetin;
        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.RichTextBox richTextBoxSoru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDersler;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelSorular;
        private System.Windows.Forms.Label lblDers;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown soruSayisiN;
    }
}

