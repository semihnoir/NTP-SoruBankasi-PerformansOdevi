namespace performans
{
    partial class SoruBankasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoruBankasi));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSoruTemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnTemizleCevaplar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxcevaplar = new System.Windows.Forms.RichTextBox();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.richTextBoxSoru = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSorular = new System.Windows.Forms.Panel();
            this.labelSoru = new System.Windows.Forms.Label();
            this.richTextBoxCsoru = new System.Windows.Forms.RichTextBox();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonileri = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxsorucevaplari = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbE = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.temizle = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDogru = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelSorular.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(-1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 292);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Controls.Add(this.buttonSoruTemizle);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnOlustur);
            this.tabPage1.Controls.Add(this.btnTemizleCevaplar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSoruEkle);
            this.tabPage1.Controls.Add(this.richTextBoxSoru);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(615, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Soru Ekle";
            // 
            // buttonSoruTemizle
            // 
            this.buttonSoruTemizle.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSoruTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSoruTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSoruTemizle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSoruTemizle.Location = new System.Drawing.Point(456, 208);
            this.buttonSoruTemizle.Name = "buttonSoruTemizle";
            this.buttonSoruTemizle.Size = new System.Drawing.Size(137, 32);
            this.buttonSoruTemizle.TabIndex = 23;
            this.buttonSoruTemizle.Text = "Soruyu Temizle";
            this.buttonSoruTemizle.UseVisualStyleBackColor = false;
            this.buttonSoruTemizle.Click += new System.EventHandler(this.buttonSoruTemizle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Soru Metni";
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.SystemColors.Control;
            this.btnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOlustur.Location = new System.Drawing.Point(155, 208);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(86, 32);
            this.btnOlustur.TabIndex = 21;
            this.btnOlustur.Text = "Test Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnTemizleCevaplar
            // 
            this.btnTemizleCevaplar.BackColor = System.Drawing.SystemColors.Control;
            this.btnTemizleCevaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizleCevaplar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizleCevaplar.Location = new System.Drawing.Point(311, 208);
            this.btnTemizleCevaplar.Name = "btnTemizleCevaplar";
            this.btnTemizleCevaplar.Size = new System.Drawing.Size(137, 32);
            this.btnTemizleCevaplar.TabIndex = 20;
            this.btnTemizleCevaplar.Text = "Cevapları Temizle";
            this.btnTemizleCevaplar.UseVisualStyleBackColor = false;
            this.btnTemizleCevaplar.Click += new System.EventHandler(this.btnTemizleCevaplar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbE);
            this.groupBox1.Controls.Add(this.rbD);
            this.groupBox1.Controls.Add(this.rbC);
            this.groupBox1.Controls.Add(this.rbB);
            this.groupBox1.Controls.Add(this.rbA);
            this.groupBox1.Controls.Add(this.richTextBoxcevaplar);
            this.groupBox1.Location = new System.Drawing.Point(311, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 182);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cevaplar";
            // 
            // richTextBoxcevaplar
            // 
            this.richTextBoxcevaplar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxcevaplar.Location = new System.Drawing.Point(51, 22);
            this.richTextBoxcevaplar.Name = "richTextBoxcevaplar";
            this.richTextBoxcevaplar.Size = new System.Drawing.Size(224, 154);
            this.richTextBoxcevaplar.TabIndex = 9;
            this.richTextBoxcevaplar.Text = "A) \nB) \nC) \nD) \nE) ";
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnSoruEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoruEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSoruEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoruEkle.Location = new System.Drawing.Point(77, 208);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(72, 32);
            this.btnSoruEkle.TabIndex = 17;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSoruEkle.UseVisualStyleBackColor = false;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // richTextBoxSoru
            // 
            this.richTextBoxSoru.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxSoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxSoru.Location = new System.Drawing.Point(24, 55);
            this.richTextBoxSoru.Name = "richTextBoxSoru";
            this.richTextBoxSoru.Size = new System.Drawing.Size(267, 147);
            this.richTextBoxSoru.TabIndex = 16;
            this.richTextBoxSoru.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage2.Controls.Add(this.panelSorular);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(615, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sorular";
            // 
            // panelSorular
            // 
            this.panelSorular.Controls.Add(this.labelDogru);
            this.panelSorular.Controls.Add(this.labelSoru);
            this.panelSorular.Controls.Add(this.richTextBoxCsoru);
            this.panelSorular.Controls.Add(this.buttonGeri);
            this.panelSorular.Controls.Add(this.buttonileri);
            this.panelSorular.Controls.Add(this.groupBox2);
            this.panelSorular.Location = new System.Drawing.Point(3, 0);
            this.panelSorular.Name = "panelSorular";
            this.panelSorular.Size = new System.Drawing.Size(609, 265);
            this.panelSorular.TabIndex = 0;
            this.panelSorular.Visible = false;
            // 
            // labelSoru
            // 
            this.labelSoru.AutoSize = true;
            this.labelSoru.Location = new System.Drawing.Point(18, 37);
            this.labelSoru.Name = "labelSoru";
            this.labelSoru.Size = new System.Drawing.Size(32, 15);
            this.labelSoru.TabIndex = 34;
            this.labelSoru.Text = "Soru";
            // 
            // richTextBoxCsoru
            // 
            this.richTextBoxCsoru.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxCsoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxCsoru.Location = new System.Drawing.Point(21, 55);
            this.richTextBoxCsoru.Name = "richTextBoxCsoru";
            this.richTextBoxCsoru.Size = new System.Drawing.Size(267, 147);
            this.richTextBoxCsoru.TabIndex = 33;
            this.richTextBoxCsoru.Text = "";
            // 
            // buttonGeri
            // 
            this.buttonGeri.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGeri.Location = new System.Drawing.Point(235, 220);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(66, 23);
            this.buttonGeri.TabIndex = 32;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = false;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonileri
            // 
            this.buttonileri.BackColor = System.Drawing.SystemColors.Control;
            this.buttonileri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonileri.Location = new System.Drawing.Point(307, 220);
            this.buttonileri.Name = "buttonileri";
            this.buttonileri.Size = new System.Drawing.Size(66, 23);
            this.buttonileri.TabIndex = 31;
            this.buttonileri.Text = "İleri";
            this.buttonileri.UseVisualStyleBackColor = false;
            this.buttonileri.Click += new System.EventHandler(this.buttonileri_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxsorucevaplari);
            this.groupBox2.Location = new System.Drawing.Point(309, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 182);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cevaplar";
            // 
            // richTextBoxsorucevaplari
            // 
            this.richTextBoxsorucevaplari.Location = new System.Drawing.Point(6, 22);
            this.richTextBoxsorucevaplari.Name = "richTextBoxsorucevaplari";
            this.richTextBoxsorucevaplari.Size = new System.Drawing.Size(270, 154);
            this.richTextBoxsorucevaplari.TabIndex = 8;
            this.richTextBoxsorucevaplari.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.hakkinda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbA.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbA.Location = new System.Drawing.Point(13, 27);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(32, 19);
            this.rbA.TabIndex = 10;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbB.Location = new System.Drawing.Point(13, 51);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(32, 19);
            this.rbB.TabIndex = 11;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbC.Location = new System.Drawing.Point(13, 74);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(32, 19);
            this.rbC.TabIndex = 12;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbD.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbD.Location = new System.Drawing.Point(12, 97);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(33, 19);
            this.rbD.TabIndex = 13;
            this.rbD.TabStop = true;
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbE
            // 
            this.rbE.AutoSize = true;
            this.rbE.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbE.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbE.Location = new System.Drawing.Point(14, 121);
            this.rbE.Name = "rbE";
            this.rbE.Size = new System.Drawing.Size(31, 19);
            this.rbE.TabIndex = 14;
            this.rbE.TabStop = true;
            this.rbE.Text = "E";
            this.rbE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Doğru \r\nCevap";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydet,
            this.cikis,
            this.temizle});
            this.dosyaToolStripMenuItem.Image = global::performans.Properties.Resources.page_file_icon;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kaydet
            // 
            this.kaydet.Image = global::performans.Properties.Resources._25398;
            this.kaydet.Name = "kaydet";
            this.kaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydet.Size = new System.Drawing.Size(224, 22);
            this.kaydet.Text = "Kaydet";
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // cikis
            // 
            this.cikis.Image = global::performans.Properties.Resources._320140;
            this.cikis.Name = "cikis";
            this.cikis.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F4)));
            this.cikis.Size = new System.Drawing.Size(224, 22);
            this.cikis.Text = "Çıkış";
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // temizle
            // 
            this.temizle.Image = global::performans.Properties.Resources.clear_24;
            this.temizle.Name = "temizle";
            this.temizle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.temizle.Size = new System.Drawing.Size(224, 22);
            this.temizle.Text = "Tüm Soruları Temizle";
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // hakkinda
            // 
            this.hakkinda.Image = global::performans.Properties.Resources._745139;
            this.hakkinda.Name = "hakkinda";
            this.hakkinda.Size = new System.Drawing.Size(85, 20);
            this.hakkinda.Text = "Hakkında";
            this.hakkinda.Click += new System.EventHandler(this.hakkinda_Click);
            // 
            // labelDogru
            // 
            this.labelDogru.AutoSize = true;
            this.labelDogru.Location = new System.Drawing.Point(488, 205);
            this.labelDogru.Name = "labelDogru";
            this.labelDogru.Size = new System.Drawing.Size(95, 15);
            this.labelDogru.TabIndex = 35;
            this.labelDogru.Text = "Doğru Seçenek: ";
            this.labelDogru.Visible = false;
            // 
            // SoruBankasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 320);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SoruBankasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soru Bankası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SoruBankasi_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelSorular.ResumeLayout(false);
            this.panelSorular.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnTemizleCevaplar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.RichTextBox richTextBoxSoru;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelSorular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonileri;
        private System.Windows.Forms.RichTextBox richTextBoxCsoru;
        private System.Windows.Forms.RichTextBox richTextBoxsorucevaplari;
        private System.Windows.Forms.RichTextBox richTextBoxcevaplar;
        private System.Windows.Forms.Button buttonSoruTemizle;
        private System.Windows.Forms.Label labelSoru;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydet;
        private System.Windows.Forms.ToolStripMenuItem cikis;
        private System.Windows.Forms.ToolStripMenuItem hakkinda;
        private System.Windows.Forms.ToolStripMenuItem temizle;
        private System.Windows.Forms.RadioButton rbE;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDogru;
    }
}

