using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace performans
{
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        DB db = new DB();
        MySqlConnection baglanti;

        private void linkLabelKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl ko = new KayitOl();
            ko.Show();
            this.Hide();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            baglanti = db.baglan();
            string komut = "select kullanici_adi,kullanici_sifre from kullanicilar where kullanici_adi=@user and kullanici_sifre=@pass";
            MySqlCommand cmd = new MySqlCommand(komut, baglanti);
            cmd.Parameters.AddWithValue("@user", textBoxKA.Text);
            cmd.Parameters.AddWithValue("@pass", textBoxPass.Text);

            SoruBankasi sb = new SoruBankasi();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if(reader.Read())
                {
                    if(textBoxKA.Text == reader.GetString("kullanici_adi")
                        && textBoxPass.Text == reader.GetString("kullanici_sifre"))
                    {
                        sb.Show();
                        this.Hide();
                    }
                }

                else if (textBoxKA.Text == "" || textBoxPass.Text == "")
                {
                    MessageBox.Show("Değerler boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GirisYap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
