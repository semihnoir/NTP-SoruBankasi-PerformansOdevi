using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace performans
{
    public partial class SoruBankasi : Form
    {
        public SoruBankasi()
        {
            InitializeComponent();
        }
        
        public static Dictionary<string, string> sorular = new Dictionary<string, string>();
        public static Dictionary<int, string> cevaplar = new Dictionary<int, string>();
        public static string[] harfler = { "A", "B", "C", "D", "E" };
        int soruIndex = 0;
        public void btnSoruEkle_Click(object sender, EventArgs e) // bu butona basıldığında dictinonary'e soru ve cevabı ekler.
        {
            try
            {
                string soru = richTextBoxSoru.Text;
                string cevap = richTextBoxcevaplar.Text;
                if (soru != "" && cevap != "")
                { 
                    if(rbA.Checked)
                    {
                        sorular.Add(soru, cevap);
                        cevaplar.Add(soruIndex, harfler[0]);
                        soruIndex++;
                        SoruEkle();
                    }

                    else if (rbB.Checked)
                    {
                        sorular.Add(soru, cevap);
                        cevaplar.Add(soruIndex, harfler[1]);
                        soruIndex++;
                        SoruEkle();
                    }

                    else if (rbC.Checked)
                    {
                        sorular.Add(soru, cevap);
                        cevaplar.Add(soruIndex, harfler[2]);
                        soruIndex++;
                        SoruEkle();
                    }

                    else if (rbD.Checked)
                    {
                        sorular.Add(soru, cevap);
                        cevaplar.Add(soruIndex, harfler[3]);
                        soruIndex++;
                        SoruEkle();
                    }

                    else if (rbE.Checked)
                    {
                        sorular.Add(soru, cevap);
                        cevaplar.Add(soruIndex, harfler[4]);
                        soruIndex++;
                        SoruEkle();
                    }

                    else
                    {
                        MessageBox.Show("Lütfen doğru cevap için bir şık seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen soru ve cevapları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SoruEkle()
        {
            richTextBoxSoru.Clear();
            richTextBoxcevaplar.Text = "A) " + Environment.NewLine + "B) " + Environment.NewLine + "C) " + Environment.NewLine + "D) " + Environment.NewLine + "E) ";
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;
            rbE.Checked = false;
        }
        private void btnOlustur_Click(object sender, EventArgs e) // bu butona basıldığında soruları oluşturur ve sorular tabPage'ine geçer.
        {
            if (sorular.Count >= 2)
            {
                labelDogru.Visible = true;
                buttonGeri.Enabled = false;
                tabControl1.SelectTab(tabPage2);
                panelSorular.Visible = true;
                labelSoru.Text = soruNo + ". Soru";
                richTextBoxCsoru.Text = sorular.Keys.ElementAt(0); // 0. indexteki (başlangıçtaki) soruyu richTextBox'a yazar. 
                richTextBoxsorucevaplari.Text = sorular.Values.ElementAt(0); // 0. indexteki (başlangıçtaki) cevabı richTextBox'a yazar.
                labelDogru.Text = "Doğru Cevap: " + cevaplar.Values.ElementAt(0); // 0. indexteki (başlangıçtaki) şıkkı label'a yazar.
            }

            else
            {
                MessageBox.Show("En az 2 soru eklemeniz gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int index = 0; // sorular arasında gezinmek için kullanılır.
        int soruNo = 1; // labelSoru nesnesine ve txt dosyasına soru numarasını yazmak için kullanılır.
        private void buttonileri_Click(object sender, EventArgs e) // bu butona basıldığında bir sonraki soru ve cevaba geçer.
        {
            index++;
            buttonGeri.Enabled = true;
            soruNo++;
            labelSoru.Text = soruNo + ". Soru"; // 1. soru 2. soru şeklinde gözükmesi açısından label ile soruNo değişkenini birleştirir.
            int say = sorular.Count;

            if (soruNo <= 0)
            {
                soruNo = 1;
                labelSoru.Text = soruNo + ". Soru";
            }


            if (soruNo >= sorular.Count)
            {
                buttonileri.Enabled = false;
                buttonGeri.Enabled = true;
            }

            else
            {
                buttonileri.Enabled = true;
            }

            richTextBoxCsoru.Text = sorular.Keys.ElementAt(index); // Belirtilen indexteki soruyu richTextBox'a yazar.
            richTextBoxsorucevaplari.Text = sorular.Values.ElementAt(index); // Belirtilen indexteki cevabı richTextBox'a yazar.
            labelDogru.Text = "Doğru Cevap: " + cevaplar.Values.ElementAt(index); // Belirtilen indexteki şıkkı label'a yazar.
        }

        private void buttonGeri_Click(object sender, EventArgs e) // bu butona basıldığında bir önceki soru ve cevaba geçer.
        {
            index--;
            buttonileri.Enabled = true;
            soruNo--;
            labelSoru.Text = soruNo + ". Soru"; // 1. soru 2. soru şeklinde gözükmesi açısından label ile soruNo değişkenini birleştirir.
            int say = sorular.Count;

            if (soruNo <= 0 || index == 0)
            {
                soruNo = 1;
                labelSoru.Text = soruNo + ". Soru";
                buttonileri.Enabled = true;
                buttonGeri.Enabled = false;
            }

            else
            {
                buttonGeri.Enabled = true;
            }

            richTextBoxCsoru.Text = sorular.Keys.ElementAt(index); // Belirtilen indexteki soruyu richTextBox'a yazar.
            richTextBoxsorucevaplari.Text = sorular.Values.ElementAt(index); // Belirtilen indexteki cevabı richTextBox'a yazar.   
            labelDogru.Text = "Doğru Cevap: " + cevaplar.Values.ElementAt(index); // Belirtilen indexteki şıkkı label'a yazar.
        }

        private void btnTemizleCevaplar_Click(object sender, EventArgs e)
        {
            richTextBoxcevaplar.Text = "A) " + Environment.NewLine + "B) " + Environment.NewLine + "C) " + Environment.NewLine + "D) " + Environment.NewLine + "E) ";
        }

        private void buttonSoruTemizle_Click(object sender, EventArgs e)
        {
            richTextBoxSoru.Clear();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            DialogResult sonuc = new DialogResult();
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kaydet_Click(object sender, EventArgs e) // Kaydet'e tıklanınca sorular dosya olarak kaydedilir.
        {
            int soruNoTxt = 1;
            int cevapNo = 1;
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "Metin Dosyası | *.txt | Word Dosyası | *.docx";
            DialogResult sonuc = kaydet.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                using (StreamWriter yazici = new StreamWriter(kaydet.FileName)) // RichTextBox'taki değerleri dosyaya yazmak için System.IO kütüphanesindeki StreamWriter'ı kullandım.
                {
                    foreach (var soru in sorular)
                    {
                        yazici.WriteLine(soruNoTxt + "-) " + soru.Key);
                        yazici.WriteLine(soru.Value);
                        yazici.WriteLine(Environment.NewLine);
                        soruNoTxt++;
                    }

                    yazici.WriteLine("Cevaplar");
                    foreach (var cevap in cevaplar)
                    {
                        yazici.WriteLine(cevapNo + "-) " + cevap.Value);
                        cevapNo++;
                    }
                }
            }
        }

        private void hakkinda_Click(object sender, EventArgs e)
        {
            Hakkinda hakkinda = new Hakkinda();
            hakkinda.Show();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            index = 0;
            soruNo = 1;
            sorular.Clear();
            richTextBoxCsoru.Clear();
            richTextBoxsorucevaplari.Clear();
            panelSorular.Visible = false;
            tabControl1.SelectTab(tabPage1);
        }

        private void SoruBankasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSoruSil_Click(object sender, EventArgs e)
        {
            SoruSil sil = new SoruSil();
            sil.listBoxSorular.Items.Clear();
            foreach (var ekle in sorular)
            {
                sil.listBoxSorular.Items.Add(ekle.Key);
            }
            sil.Show();
        }

        private void SoruBankasi_Load(object sender, EventArgs e)
        {
            
        }
    }
}
