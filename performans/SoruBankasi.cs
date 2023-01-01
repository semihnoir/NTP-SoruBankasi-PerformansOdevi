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
        int cevaplar = 0;
        public void btnSoruEkle_Click(object sender, EventArgs e) // bu butona basıldığında dictinonary'e soru ve cevabı ekler.
        {
            cevaplar++;
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

        int index = 0;
        int soruNo = 1;
        private void btnOlustur_Click(object sender, EventArgs e) // bu butona basıldığında soruları oluşturur ve sorular tabPage'ine geçer.
        {
            tabControl1.SelectTab(tabPage2);
            panelSorular.Visible = true;
            labelSoru.Text = soruNo + ". Soru";
            foreach (var soru in sorular.Keys)
            {
                richTextBoxCsoru.Text = soru + Environment.NewLine;
            }

            foreach (var soru in sorular.Values)
            {
                richTextBoxsorucevaplari.Text = soru + Environment.NewLine;
            }
            
        }
       
        private void buttonileri_Click(object sender, EventArgs e) // bu butona basıldığında bir sonraki soru ve cevaba geçer.
        {
            soruNo++;
            labelSoru.Text = soruNo + ". Soru"; // 1. soru 2. soru şeklinde gözükmesi açısından label ile soruNo değişkenini birleştirir.
            int say = sorular.Count;
            if (index == say)
            {
                index = 0;
            }

            richTextBoxCsoru.Text = sorular.Keys.ElementAt(index); // Belirtilen indexteki soruyu richTextBox'a yazar. 
            richTextBoxsorucevaplari.Text = sorular.Values.ElementAt(index); // Belirtilen indexteki cevabı richTextBox'a yazar.

            index++;
        }

        private void buttonGeri_Click(object sender, EventArgs e) // bu butona basıldığında bir önceki soru ve cevaba geçer.
        {
            soruNo--;
            labelSoru.Text = soruNo + ". Soru"; // 1. soru 2. soru şeklinde gözükmesi açısından label ile soruNo değişkenini birleştirir.
            int say = sorular.Count;

            if (index == 0)
            {
                index = say;
            }

            richTextBoxCsoru.Text = sorular.Keys.ElementAt(index - 1); // Belirtilen indexteki soruyu richTextBox'a yazar.
            richTextBoxsorucevaplari.Text = sorular.Values.ElementAt(index - 1); // Belirtilen indexteki cevabı richTextBox'a yazar.

            index--;
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
                        yazici.WriteLine(soruNoTxt + ". Soru");
                        yazici.WriteLine(soru.Key);
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
    }
}
