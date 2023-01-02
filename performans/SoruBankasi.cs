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

namespace performans
{
    public partial class SoruBankasi : Form
    {
        public SoruBankasi()
        {
            InitializeComponent();
        }
        
        Dictionary<string, string> sorular = new Dictionary<string, string>();
        public void btnSoruEkle_Click(object sender, EventArgs e) // bu butona basıldığında dictinonary'e soru ve cevabı ekler.
        {
            try
            {
                string soru = richTextBoxSoru.Text;
                string cevap = richTextBoxcevaplar.Text;
                if (soru != "" && cevap != "")
                {
                    sorular.Add(soru, cevap);
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

            richTextBoxSoru.Clear();
            richTextBoxcevaplar.Text = "A) " + Environment.NewLine + "B) " + Environment.NewLine + "C) " + Environment.NewLine + "D) " + Environment.NewLine + "E) ";
        }

        
        private void btnOlustur_Click(object sender, EventArgs e) // bu butona basıldığında soruları oluşturur ve sorular tabPage'ine geçer.
        {
            if (sorular.Count >= 2)
            {
                index = 0;
                buttonGeri.Enabled = false;
                tabControl1.SelectTab(tabPage2);
                panelSorular.Visible = true;
                labelSoru.Text = soruNo + ". Soru";
                richTextBoxCsoru.Text = sorular.Keys.ElementAt(0); // 0. indexteki (başlangıçtaki) soruyu richTextBox'a yazar. 
                richTextBoxsorucevaplari.Text = sorular.Values.ElementAt(0); // 0. indexteki (başlangıçtaki) cevabı richTextBox'a yazar.
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
            MessageBox.Show("Çıkmak istedğinizden emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            DialogResult sonuc = new DialogResult();
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kaydet_Click(object sender, EventArgs e) // Kaydet'e tıklanınca sorular dosya olarak kaydedilir.
        {
            int soruNoTxt = 1;
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
    }
}
