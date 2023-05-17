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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        DB db = new DB();
        MySqlConnection baglanti;

        private void linkLabelGiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GirisYap gy = new GirisYap();
            gy.Show();
            this.Hide();
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            baglanti = db.baglan();
            string kontrol = "select kullanici_adi,kullanici_sifre from kullanicilar where kullanici_adi=@user and kullanici_sifre=@pass";
            string komut = "insert into kullanicilar(kullanici_adi,kullanici_sifre) values(@user,@pass)";
            MySqlCommand cmd = new MySqlCommand(kontrol,baglanti);
            cmd.Parameters.AddWithValue("@user", textBoxKA.Text);
            cmd.Parameters.AddWithValue("@pass", textBoxPass.Text);

            SoruBankasi sb = new SoruBankasi();
            string user = "admin";
            string pass = "admin";

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    user = reader.GetString("kullanici_adi");
                    pass = reader.GetString("kullanici_sifre");
                }
            }

            if (textBoxKA.Text == user && textBoxPass.Text == pass)
            {
                MessageBox.Show("Böyle bir kullanıcı mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (textBoxKA.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Değerler boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                cmd = new MySqlCommand(komut, baglanti);
                cmd.Parameters.AddWithValue("@user", textBoxKA.Text);
                cmd.Parameters.AddWithValue("@pass", textBoxPass.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sb.Show();
                this.Hide();
            }
        }

        private void KayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
