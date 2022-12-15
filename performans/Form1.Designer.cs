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
            this.textBoxSoruSayisi = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnTemizleCevaplar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.btnTemizleMetin = new System.Windows.Forms.Button();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.richTextBoxSoru = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDersler = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSorular = new System.Windows.Forms.Panel();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxC3 = new System.Windows.Forms.TextBox();
            this.radioButtonCC = new System.Windows.Forms.RadioButton();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.radioButtonCB = new System.Windows.Forms.RadioButton();
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.radioButtonCA = new System.Windows.Forms.RadioButton();
            this.labelSoru = new System.Windows.Forms.Label();
            this.richTextBoxMetinC = new System.Windows.Forms.RichTextBox();
            this.lblDers = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelSorular.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 319);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxSoruSayisi);
            this.tabPage1.Controls.Add(this.btnOlustur);
            this.tabPage1.Controls.Add(this.btnTemizleCevaplar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnTemizleMetin);
            this.tabPage1.Controls.Add(this.btnSoruEkle);
            this.tabPage1.Controls.Add(this.richTextBoxSoru);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxDersler);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(525, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Soru Ekle";
            this.tabPage1.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Soru Sayısı";
            // 
            // textBoxSoruSayisi
            // 
            this.textBoxSoruSayisi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoruSayisi.Location = new System.Drawing.Point(100, 43);
            this.textBoxSoruSayisi.Multiline = true;
            this.textBoxSoruSayisi.Name = "textBoxSoruSayisi";
            this.textBoxSoruSayisi.Size = new System.Drawing.Size(36, 29);
            this.textBoxSoruSayisi.TabIndex = 22;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOlustur.Location = new System.Drawing.Point(228, 241);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(82, 29);
            this.btnOlustur.TabIndex = 21;
            this.btnOlustur.Text = "Test Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnTemizleCevaplar
            // 
            this.btnTemizleCevaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizleCevaplar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizleCevaplar.Location = new System.Drawing.Point(288, 199);
            this.btnTemizleCevaplar.Name = "btnTemizleCevaplar";
            this.btnTemizleCevaplar.Size = new System.Drawing.Size(123, 29);
            this.btnTemizleCevaplar.TabIndex = 20;
            this.btnTemizleCevaplar.Text = "Cevapları Temizle";
            this.btnTemizleCevaplar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxC);
            this.groupBox1.Controls.Add(this.radioButtonC);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Controls.Add(this.radioButtonB);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.radioButtonA);
            this.groupBox1.Location = new System.Drawing.Point(288, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 182);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cevaplar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(100, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cevap";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru\r\nCevap";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(45, 145);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(160, 28);
            this.textBoxC.TabIndex = 5;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(4, 149);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(35, 20);
            this.radioButtonC.TabIndex = 4;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(45, 102);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(160, 28);
            this.textBoxB.TabIndex = 3;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(4, 106);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(33, 20);
            this.radioButtonB.TabIndex = 2;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(45, 56);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(160, 28);
            this.textBoxA.TabIndex = 1;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(4, 60);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(35, 20);
            this.radioButtonA.TabIndex = 0;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // btnTemizleMetin
            // 
            this.btnTemizleMetin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizleMetin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizleMetin.Location = new System.Drawing.Point(151, 43);
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
            this.btnSoruEkle.Location = new System.Drawing.Point(417, 199);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(82, 29);
            this.btnSoruEkle.TabIndex = 17;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = true;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // richTextBoxSoru
            // 
            this.richTextBoxSoru.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxSoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxSoru.Location = new System.Drawing.Point(29, 82);
            this.richTextBoxSoru.Name = "richTextBoxSoru";
            this.richTextBoxSoru.Size = new System.Drawing.Size(225, 130);
            this.richTextBoxSoru.TabIndex = 16;
            this.richTextBoxSoru.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
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
            this.comboBoxDersler.Location = new System.Drawing.Point(65, 11);
            this.comboBoxDersler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDersler.Name = "comboBoxDersler";
            this.comboBoxDersler.Size = new System.Drawing.Size(189, 24);
            this.comboBoxDersler.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panelSorular);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sorular";
            // 
            // panelSorular
            // 
            this.panelSorular.Controls.Add(this.lblDers);
            this.panelSorular.Controls.Add(this.btnOnceki);
            this.panelSorular.Controls.Add(this.btnSonraki);
            this.panelSorular.Controls.Add(this.groupBox2);
            this.panelSorular.Controls.Add(this.labelSoru);
            this.panelSorular.Controls.Add(this.richTextBoxMetinC);
            this.panelSorular.Location = new System.Drawing.Point(3, 3);
            this.panelSorular.Name = "panelSorular";
            this.panelSorular.Size = new System.Drawing.Size(518, 284);
            this.panelSorular.TabIndex = 0;
            this.panelSorular.Visible = false;
            // 
            // btnOnceki
            // 
            this.btnOnceki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnceki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnceki.ImageKey = "(none)";
            this.btnOnceki.Location = new System.Drawing.Point(196, 205);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(60, 28);
            this.btnOnceki.TabIndex = 27;
            this.btnOnceki.Text = "Önceki";
            this.btnOnceki.UseVisualStyleBackColor = true;
            // 
            // btnSonraki
            // 
            this.btnSonraki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSonraki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSonraki.ImageKey = "(none)";
            this.btnSonraki.Location = new System.Drawing.Point(262, 205);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(60, 28);
            this.btnSonraki.TabIndex = 26;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxC3);
            this.groupBox2.Controls.Add(this.radioButtonCC);
            this.groupBox2.Controls.Add(this.textBoxC2);
            this.groupBox2.Controls.Add(this.radioButtonCB);
            this.groupBox2.Controls.Add(this.textBoxC1);
            this.groupBox2.Controls.Add(this.radioButtonCA);
            this.groupBox2.Location = new System.Drawing.Point(283, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 150);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cevaplar";
            // 
            // textBoxC3
            // 
            this.textBoxC3.Location = new System.Drawing.Point(45, 110);
            this.textBoxC3.Multiline = true;
            this.textBoxC3.Name = "textBoxC3";
            this.textBoxC3.Size = new System.Drawing.Size(160, 28);
            this.textBoxC3.TabIndex = 5;
            // 
            // radioButtonCC
            // 
            this.radioButtonCC.AutoSize = true;
            this.radioButtonCC.Location = new System.Drawing.Point(4, 114);
            this.radioButtonCC.Name = "radioButtonCC";
            this.radioButtonCC.Size = new System.Drawing.Size(35, 20);
            this.radioButtonCC.TabIndex = 4;
            this.radioButtonCC.TabStop = true;
            this.radioButtonCC.Text = "C";
            this.radioButtonCC.UseVisualStyleBackColor = true;
            // 
            // textBoxC2
            // 
            this.textBoxC2.Location = new System.Drawing.Point(45, 67);
            this.textBoxC2.Multiline = true;
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.Size = new System.Drawing.Size(160, 28);
            this.textBoxC2.TabIndex = 3;
            // 
            // radioButtonCB
            // 
            this.radioButtonCB.AutoSize = true;
            this.radioButtonCB.Location = new System.Drawing.Point(4, 71);
            this.radioButtonCB.Name = "radioButtonCB";
            this.radioButtonCB.Size = new System.Drawing.Size(33, 20);
            this.radioButtonCB.TabIndex = 2;
            this.radioButtonCB.TabStop = true;
            this.radioButtonCB.Text = "B";
            this.radioButtonCB.UseVisualStyleBackColor = true;
            // 
            // textBoxC1
            // 
            this.textBoxC1.Location = new System.Drawing.Point(45, 21);
            this.textBoxC1.Multiline = true;
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.Size = new System.Drawing.Size(160, 28);
            this.textBoxC1.TabIndex = 1;
            // 
            // radioButtonCA
            // 
            this.radioButtonCA.AutoSize = true;
            this.radioButtonCA.Location = new System.Drawing.Point(4, 25);
            this.radioButtonCA.Name = "radioButtonCA";
            this.radioButtonCA.Size = new System.Drawing.Size(35, 20);
            this.radioButtonCA.TabIndex = 0;
            this.radioButtonCA.TabStop = true;
            this.radioButtonCA.Text = "A";
            this.radioButtonCA.UseVisualStyleBackColor = true;
            // 
            // labelSoru
            // 
            this.labelSoru.AutoSize = true;
            this.labelSoru.Location = new System.Drawing.Point(24, 20);
            this.labelSoru.Name = "labelSoru";
            this.labelSoru.Size = new System.Drawing.Size(43, 16);
            this.labelSoru.TabIndex = 24;
            this.labelSoru.Text = "Soru x";
            // 
            // richTextBoxMetinC
            // 
            this.richTextBoxMetinC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxMetinC.Location = new System.Drawing.Point(24, 39);
            this.richTextBoxMetinC.Name = "richTextBoxMetinC";
            this.richTextBoxMetinC.Size = new System.Drawing.Size(214, 131);
            this.richTextBoxMetinC.TabIndex = 23;
            this.richTextBoxMetinC.Text = "";
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Location = new System.Drawing.Point(133, 20);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(39, 16);
            this.lblDers.TabIndex = 28;
            this.lblDers.Text = "Ders: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 320);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoruSayisi;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnTemizleCevaplar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.Button btnTemizleMetin;
        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.RichTextBox richTextBoxSoru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDersler;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelSorular;
        private System.Windows.Forms.Button btnOnceki;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxC3;
        private System.Windows.Forms.RadioButton radioButtonCC;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.RadioButton radioButtonCB;
        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.RadioButton radioButtonCA;
        private System.Windows.Forms.Label labelSoru;
        private System.Windows.Forms.RichTextBox richTextBoxMetinC;
        private System.Windows.Forms.Label lblDers;
    }
}

