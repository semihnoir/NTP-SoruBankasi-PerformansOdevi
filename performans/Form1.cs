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

namespace performans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Dictionary<int, string> sorular = new Dictionary<int, string>();
        Dictionary<int, string> soruCevaplari = new Dictionary<int, string>();
        char[] siklar = { 'A', 'B', 'C' };
        int soruNo = 1;
        int soruLbl = 1;
        int cevaplar = 0;
        public void btnSoruEkle_Click(object sender, EventArgs e)
        {
            cevaplar++;
            try
            {
                sorular.Add(soruNo, richTextBoxSoru.Text);
                for (int i = 1; i<=3; i++)
                {
                    TextBox sorumetni = this.Controls.Find("textBox" + i, true)[0] as TextBox;
                    soruCevaplari.Add(i, sorumetni.Text);
                }
                
                soruNo++;
                soruLbl++;

                if (richTextBoxSoru.Text == "")
                {
                    MessageBox.Show("Lütfen soru metnini doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBoxSoru.Focus();
                }

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Lütfen soru cevaplarını doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Bilinmeyen bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            richTextBoxSoru.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            int indexSiklar = 0;
            foreach (var soru in sorular)
            {
                for(int i = 1;i<=3;i++)
                {
                    listBox1.Items.Add(soru.Key + ". Soru: " + soru.Value + " " + siklar[indexSiklar] +  ": " + soruCevaplari[i]);
                    indexSiklar++;
                }
                listBox1.Items.Add("");
            }

            tabControl1.SelectTab(tabPage2);
            panelSorular.Visible = true;
        }

        int index = 1;

        private void SoruGoster()
        {
            index++;
            
        }
    }
}
