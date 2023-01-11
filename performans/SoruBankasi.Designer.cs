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
            this.btnSoruTemizle = new System.Windows.Forms.Button();
            this.btnSoruSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnTemizleCevaplar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbE = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.richTextBoxcevaplar = new System.Windows.Forms.RichTextBox();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.richTextBoxSoru = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSorular = new System.Windows.Forms.Panel();
            this.labelDogru = new System.Windows.Forms.Label();
            this.labelSoru = new System.Windows.Forms.Label();
            this.richTextBoxCsoru = new System.Windows.Forms.RichTextBox();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonileri = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxsorucevaplari = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.temizle = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkinda = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabControl1.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnSoruTemizle);
            this.tabPage1.Controls.Add(this.btnSoruSil);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnOlustur);
            this.tabPage1.Controls.Add(this.btnTemizleCevaplar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSoruEkle);
            this.tabPage1.Controls.Add(this.richTextBoxSoru);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Soru Ekle";
            // 
            // btnSoruTemizle
            // 
            this.btnSoruTemizle.BackColor = System.Drawing.SystemColors.Control;
            this.btnSoruTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoruTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSoruTemizle.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruTemizle.Location = new System.Drawing.Point(501, 214);
            this.btnSoruTemizle.Name = "btnSoruTemizle";
            this.btnSoruTemizle.Size = new System.Drawing.Size(137, 32);
            this.btnSoruTemizle.TabIndex = 25;
            this.btnSoruTemizle.Text = "Soruları Temizle";
            this.btnSoruTemizle.UseVisualStyleBackColor = false;
            this.btnSoruTemizle.Click += new System.EventHandler(this.buttonSoruTemizle_Click);
            // 
            // btnSoruSil
            // 
            this.btnSoruSil.BackColor = System.Drawing.SystemColors.Control;
            this.btnSoruSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoruSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSoruSil.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruSil.Location = new System.Drawing.Point(230, 214);
            this.btnSoruSil.Name = "btnSoruSil";
            this.btnSoruSil.Size = new System.Drawing.Size(96, 32);
            this.btnSoruSil.TabIndex = 24;
            this.btnSoruSil.Text = "Soru Sil";
            this.btnSoruSil.UseVisualStyleBackColor = false;
            this.btnSoruSil.Click += new System.EventHandler(this.btnSoruSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Soru Metni";
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.SystemColors.Control;
            this.btnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOlustur.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(123, 214);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(101, 32);
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
            this.btnTemizleCevaplar.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizleCevaplar.Location = new System.Drawing.Point(356, 214);
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
            this.groupBox1.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(356, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 182);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cevaplar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Doğru \r\nCevap";
            // 
            // rbE
            // 
            this.rbE.AutoSize = true;
            this.rbE.BackColor = System.Drawing.Color.Transparent;
            this.rbE.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbE.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbE.Location = new System.Drawing.Point(14, 121);
            this.rbE.Name = "rbE";
            this.rbE.Size = new System.Drawing.Size(33, 19);
            this.rbE.TabIndex = 14;
            this.rbE.TabStop = true;
            this.rbE.Text = "E";
            this.rbE.UseVisualStyleBackColor = false;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.BackColor = System.Drawing.Color.Transparent;
            this.rbD.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbD.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbD.Location = new System.Drawing.Point(12, 97);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(34, 19);
            this.rbD.TabIndex = 13;
            this.rbD.TabStop = true;
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = false;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.BackColor = System.Drawing.Color.Transparent;
            this.rbC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbC.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbC.Location = new System.Drawing.Point(13, 74);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(34, 19);
            this.rbC.TabIndex = 12;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = false;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.BackColor = System.Drawing.Color.Transparent;
            this.rbB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbB.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbB.Location = new System.Drawing.Point(13, 51);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(34, 19);
            this.rbB.TabIndex = 11;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = false;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.BackColor = System.Drawing.Color.Transparent;
            this.rbA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbA.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbA.Location = new System.Drawing.Point(13, 27);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(34, 19);
            this.rbA.TabIndex = 10;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = false;
            // 
            // richTextBoxcevaplar
            // 
            this.richTextBoxcevaplar.Font = new System.Drawing.Font("TRT Regular", 14.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxcevaplar.Location = new System.Drawing.Point(60, 20);
            this.richTextBoxcevaplar.Name = "richTextBoxcevaplar";
            this.richTextBoxcevaplar.Size = new System.Drawing.Size(211, 154);
            this.richTextBoxcevaplar.TabIndex = 9;
            this.richTextBoxcevaplar.Text = "A) \nB) \nC) \nD) \nE) ";
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnSoruEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoruEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSoruEkle.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoruEkle.Location = new System.Drawing.Point(25, 214);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(92, 32);
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
            this.richTextBoxSoru.Font = new System.Drawing.Font("TRT Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxSoru.Location = new System.Drawing.Point(24, 61);
            this.richTextBoxSoru.Name = "richTextBoxSoru";
            this.richTextBoxSoru.Size = new System.Drawing.Size(302, 147);
            this.richTextBoxSoru.TabIndex = 16;
            this.richTextBoxSoru.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage2.Controls.Add(this.panelSorular);
            this.tabPage2.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sorular";
            // 
            // panelSorular
            // 
            this.panelSorular.BackColor = System.Drawing.SystemColors.Control;
            this.panelSorular.Controls.Add(this.labelDogru);
            this.panelSorular.Controls.Add(this.labelSoru);
            this.panelSorular.Controls.Add(this.richTextBoxCsoru);
            this.panelSorular.Controls.Add(this.buttonGeri);
            this.panelSorular.Controls.Add(this.buttonileri);
            this.panelSorular.Controls.Add(this.groupBox2);
            this.panelSorular.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSorular.Location = new System.Drawing.Point(3, 0);
            this.panelSorular.Name = "panelSorular";
            this.panelSorular.Size = new System.Drawing.Size(653, 269);
            this.panelSorular.TabIndex = 0;
            this.panelSorular.Visible = false;
            // 
            // labelDogru
            // 
            this.labelDogru.AutoSize = true;
            this.labelDogru.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDogru.Location = new System.Drawing.Point(506, 208);
            this.labelDogru.Name = "labelDogru";
            this.labelDogru.Size = new System.Drawing.Size(103, 15);
            this.labelDogru.TabIndex = 35;
            this.labelDogru.Text = "Doğru Seçenek: ";
            this.labelDogru.Visible = false;
            // 
            // labelSoru
            // 
            this.labelSoru.AutoSize = true;
            this.labelSoru.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoru.Location = new System.Drawing.Point(40, 40);
            this.labelSoru.Name = "labelSoru";
            this.labelSoru.Size = new System.Drawing.Size(34, 15);
            this.labelSoru.TabIndex = 34;
            this.labelSoru.Text = "Soru";
            // 
            // richTextBoxCsoru
            // 
            this.richTextBoxCsoru.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxCsoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxCsoru.Font = new System.Drawing.Font("TRT Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxCsoru.Location = new System.Drawing.Point(43, 58);
            this.richTextBoxCsoru.Name = "richTextBoxCsoru";
            this.richTextBoxCsoru.Size = new System.Drawing.Size(267, 147);
            this.richTextBoxCsoru.TabIndex = 33;
            this.richTextBoxCsoru.Text = "";
            // 
            // buttonGeri
            // 
            this.buttonGeri.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGeri.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.Location = new System.Drawing.Point(257, 223);
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
            this.buttonileri.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonileri.Location = new System.Drawing.Point(329, 223);
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
            this.groupBox2.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(331, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 182);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cevaplar";
            // 
            // richTextBoxsorucevaplari
            // 
            this.richTextBoxsorucevaplari.Font = new System.Drawing.Font("TRT Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxsorucevaplari.Location = new System.Drawing.Point(6, 22);
            this.richTextBoxsorucevaplari.Name = "richTextBoxsorucevaplari";
            this.richTextBoxsorucevaplari.Size = new System.Drawing.Size(270, 154);
            this.richTextBoxsorucevaplari.TabIndex = 8;
            this.richTextBoxsorucevaplari.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.hakkinda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydet,
            this.cikis,
            this.temizle});
            this.dosyaToolStripMenuItem.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaToolStripMenuItem.Image = global::performans.Properties.Resources.page_file_icon;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kaydet
            // 
            this.kaydet.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Image = global::performans.Properties.Resources._25398;
            this.kaydet.Name = "kaydet";
            this.kaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydet.Size = new System.Drawing.Size(244, 22);
            this.kaydet.Text = "Kaydet";
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // temizle
            // 
            this.temizle.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle.Image = global::performans.Properties.Resources.clear_24;
            this.temizle.Name = "temizle";
            this.temizle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.temizle.Size = new System.Drawing.Size(244, 22);
            this.temizle.Text = "Tüm Soruları Temizle";
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // hakkinda
            // 
            this.hakkinda.Font = new System.Drawing.Font("TRT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hakkinda.Image = global::performans.Properties.Resources._745139;
            this.hakkinda.Name = "hakkinda";
            this.hakkinda.Size = new System.Drawing.Size(94, 20);
            this.hakkinda.Text = "Hakkında";
            this.hakkinda.Click += new System.EventHandler(this.hakkinda_Click);
            // 
            // SoruBankasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(663, 324);
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
            this.Load += new System.EventHandler(this.SoruBankasi_Load);
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
        private System.Windows.Forms.Button btnSoruSil;
        private System.Windows.Forms.Button btnSoruTemizle;
    }
}

