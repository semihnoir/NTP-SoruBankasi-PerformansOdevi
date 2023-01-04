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
using Microsoft.VisualBasic;

namespace performans
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        Dictionary<string, string> girisbilgileri = new Dictionary<string, string>();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxUser.Text;
            string sifre = textBoxPass.Text;

            if(girisbilgileri.Keys.Contains(kullaniciAdi) && girisbilgileri.Values.Contains(sifre))
            {
                MessageBox.Show("Giriş başarılı.", "Giriş Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoruBankasi sorubankasi = new SoruBankasi();
                sorubankasi.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifreniz yanlış.", "Giriş Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = Interaction.InputBox("Kullanıcı adınızı girin: ", "Kayıt Ol", "");
            string sifre = Interaction.InputBox("Şifrenizi girin: ", "Kayıt Ol", "");

            try
            {
                if (kullaniciAdi == "" || sifre == "")
                {
                    MessageBox.Show("Lütfen boşlukları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Kayıt başarılı.", "Kayıt Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    girisbilgileri.Add(kullaniciAdi, sifre);
                    textBoxUser.Text = kullaniciAdi;
                    textBoxPass.Text = sifre;
                }
            }

            catch
            {
                MessageBox.Show("Lütfen boşlukları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
