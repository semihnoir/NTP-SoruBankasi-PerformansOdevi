using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace performans
{
    public partial class SoruSil : Form
    {
        public SoruSil()
        {
            InitializeComponent();
        }

        SoruBankasi soru = new SoruBankasi();
        DB db = new DB();
        MySqlConnection baglanti;
        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBoxSorular.SelectedIndex + 1;
            string cevap = "delete FROM cevaplar where cevap_id = @id";
            MySqlCommand cevapCmd = new MySqlCommand(cevap, baglanti);
            cevapCmd.Parameters.AddWithValue("@id", index);
            cevapCmd.ExecuteNonQuery();


            string soru = "delete FROM sorular where soru_id = @id";
            MySqlCommand soruCmd = new MySqlCommand(soru, baglanti);
            soruCmd.Parameters.AddWithValue("@id", index);
            soruCmd.ExecuteNonQuery();

            listBoxSorular.Items.Clear();
            Listele();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSil.Text = listBoxSorular.Text;
        }

        private void SoruSil_Load(object sender, EventArgs e)
        {
            baglanti = db.baglan();

            Listele();
        }

        void Listele()
        {
            string query = "SELECT soru_metni FROM sorular";
            MySqlCommand cmd = new MySqlCommand(query, baglanti);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                listBoxSorular.Items.Clear();

                while (reader.Read())
                {
                    string veri = reader.GetString(0);
                    listBoxSorular.Items.Add(veri);
                }
            }
        }
    }
}
