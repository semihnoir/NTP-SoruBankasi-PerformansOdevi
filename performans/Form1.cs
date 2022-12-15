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
        int soruNo = 1;
        int soruLbl = 0;
        string soruMetni = "";
        public void btnSoruEkle_Click(object sender, EventArgs e)
        {
            soruMetni = richTextBoxSoru.Text;
            try
            {
                sorular.Add(soruNo, soruMetni);

                soruCevaplari.Add(1, textBoxA.Text);
                soruCevaplari.Add(2, textBoxB.Text);
                soruCevaplari.Add(3, textBoxC.Text);
                soruNo++;
                soruLbl++;

                if (richTextBoxSoru.Text == "")
                {
                    MessageBox.Show("Lütfen soru metnini doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBoxSoru.Focus();
                }

                if (textBoxA.Text == "" || textBoxB.Text == "" || textBoxC.Text == "")
                {
                    MessageBox.Show("Lütfen soru cevaplarını doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxA.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Bilinmeyen bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            foreach (var metin in sorular)
            {
                richTextBoxMetinC.Text = metin.Value;
            }

            for(int i=1;i<=3;i++)
            {
                TextBox cevap = this.Controls.Find("textBoxC" + i,true)[0] as TextBox;
                cevap.Text = soruCevaplari[i];
            }

            if(radioButtonA.Checked == true)
            {
                radioButtonCA.Select();
            }

            else if(radioButtonB.Checked == true)
            {
                radioButtonCB.Select();
            }

            else if (radioButtonC.Checked == true)
            {
                radioButtonCC.Select();
            }

            else
            {
                MessageBox.Show("Lütfen doğru cevap belirtin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButtonA.Focus();
            }

            if (comboBoxDersler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen ders seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxDersler.Focus();
            }

            labelSoru.Text = "Soru " + soruLbl;
            lblDers.Text = comboBoxDersler.SelectedText;
            tabControl1.SelectedTab = tabPage2;
            panelSorular.Visible = true;
        }
    }
}
