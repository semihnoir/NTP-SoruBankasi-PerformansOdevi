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
    public partial class SoruDuzenle : Form
    {
        public SoruDuzenle()
        {
            InitializeComponent();
        }

        DB db = new DB();
        MySqlConnection baglanti;

        private void SoruDuzenle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }

            string komut = "update sorular,cevaplar set soru_metni=@sm,dogruCevap=@dgr,a=@a,b=@b,c=@c,d=@d,e=@e,cevap=@cevap where soru_no = @no";
            MySqlCommand cmd = new MySqlCommand(komut, baglanti);
            cmd.Parameters.AddWithValue("@no", int.Parse(dataGridView1.CurrentRow.Cells["soru_no"].Value.ToString()));
            cmd.Parameters.AddWithValue("@sm", richTextBoxSoru.Text);
            if (radioButtonA.Checked)
            {
                cmd.Parameters.AddWithValue("@dgr", "A");
            }

            else if (radioButtonB.Checked)
            {
                cmd.Parameters.AddWithValue("@dgr", "B");
            }

            else if (radioButtonC.Checked)
            {
                cmd.Parameters.AddWithValue("@dgr", "C");
            }

            else if (radioButtonD.Checked)
            {
                cmd.Parameters.AddWithValue("@dgr", "D");
            }

            else if (radioButtonE.Checked)
            {
                cmd.Parameters.AddWithValue("@dgr", "E");
            }

            cmd.Parameters.AddWithValue("@a", textBoxA.Text);
            cmd.Parameters.AddWithValue("@b", textBoxB.Text);
            cmd.Parameters.AddWithValue("@c", textBoxC.Text);
            cmd.Parameters.AddWithValue("@d", textBoxD.Text);
            cmd.Parameters.AddWithValue("@e", textBoxE.Text);
            cmd.Parameters.AddWithValue("@cevap", textBoxA.Text + "\n" + textBoxB.Text + "\n" + textBoxC.Text + "\n" + textBoxD.Text + "\n" + textBoxE.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            Temizle();
            Listele();
            MessageBox.Show("Güncelleme başarılı.", "İşlemler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                string cevap = "delete FROM cevaplar where cevap_id = @id";
                MySqlCommand cevapCmd = new MySqlCommand(cevap, baglanti);
                cevapCmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["soru_no"].Value.ToString());
                cevapCmd.ExecuteNonQuery();


                string soru = "delete FROM sorular where soru_id = @id";
                MySqlCommand soruCmd = new MySqlCommand(soru, baglanti);
                soruCmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["soru_no"].Value.ToString());
                soruCmd.ExecuteNonQuery();
                Temizle();
                Listele();
                MessageBox.Show("Silme başarılı.", "İşlemler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Lütfen bir soru seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Listele()
        {
            baglanti = db.baglan();
            string komut = "select soru_no,soru_metni,dogruCevap,a,b,c,d,e from sorular,cevaplar where sorular.soru_id=cevaplar.soru_id";

            MySqlDataAdapter adtr = new MySqlDataAdapter(komut, baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns["soru_no"].HeaderText = "Soru No";
            dataGridView1.Columns["soru_metni"].HeaderText = "Soru Metni";
            dataGridView1.Columns["dogruCevap"].HeaderText = "Doğru Cevap";
            dataGridView1.Columns["a"].HeaderText = "A Şıkkı";
            dataGridView1.Columns["b"].HeaderText = "B Şıkkı";
            dataGridView1.Columns["c"].HeaderText = "C Şıkkı";
            dataGridView1.Columns["d"].HeaderText = "D Şıkkı";
            dataGridView1.Columns["e"].HeaderText = "E Şıkkı";

            dataGridView1.Columns["soru_no"].Width = 50;
            dataGridView1.Columns["soru_metni"].Width = 100;
            dataGridView1.Columns["dogruCevap"].Width = 50;
            dataGridView1.Columns["a"].Width = 100;
            dataGridView1.Columns["b"].Width = 100;
            dataGridView1.Columns["c"].Width = 100;
            dataGridView1.Columns["d"].Width = 100;
            dataGridView1.Columns["e"].Width = 100;
        }

        void Temizle()
        {
            richTextBoxSoru.Clear();
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxD.Clear();
            textBoxE.Clear();
        }

        void SoruAra(string aranacakKelime)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "select soru_no,soru_metni,dogruCevap,a,b,c,d,e from sorular,cevaplar where sorular.soru_id=cevaplar.soru_id and soru_metni like '" + aranacakKelime + "%'";
            MySqlDataAdapter adtr = new MySqlDataAdapter(cmd);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();
            dataGridView1.DataSource = tablo;

            dataGridView1.Columns["soru_no"].HeaderText = "Soru No";
            dataGridView1.Columns["soru_metni"].HeaderText = "Soru Metni";
            dataGridView1.Columns["dogruCevap"].HeaderText = "Doğru Cevap";
            dataGridView1.Columns["a"].HeaderText = "A Şıkkı";
            dataGridView1.Columns["b"].HeaderText = "B Şıkkı";
            dataGridView1.Columns["c"].HeaderText = "C Şıkkı";
            dataGridView1.Columns["d"].HeaderText = "D Şıkkı";
            dataGridView1.Columns["e"].HeaderText = "E Şıkkı";

            dataGridView1.Columns["soru_no"].Width = 50;
            dataGridView1.Columns["soru_metni"].Width = 100;
            dataGridView1.Columns["dogruCevap"].Width = 50;
            dataGridView1.Columns["a"].Width = 100;
            dataGridView1.Columns["b"].Width = 100;
            dataGridView1.Columns["c"].Width = 100;
            dataGridView1.Columns["d"].Width = 100;
            dataGridView1.Columns["e"].Width = 100;
        }

        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            if(textBoxAra.Text == "")
            {
                Listele();
            }

            else
            {
                SoruAra(textBoxAra.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBoxSoru.Text = dataGridView1.CurrentRow.Cells["soru_metni"].Value.ToString();
            textBoxA.Text = dataGridView1.CurrentRow.Cells["a"].Value.ToString();
            textBoxB.Text = dataGridView1.CurrentRow.Cells["b"].Value.ToString();
            textBoxC.Text = dataGridView1.CurrentRow.Cells["c"].Value.ToString();
            textBoxD.Text = dataGridView1.CurrentRow.Cells["d"].Value.ToString();
            textBoxE.Text = dataGridView1.CurrentRow.Cells["e"].Value.ToString();

            if(radioButtonA.Name.Contains(dataGridView1.CurrentRow.Cells["dogruCevap"].Value.ToString()))
            {
                radioButtonA.Checked = true;
            }

            else if (radioButtonB.Name.Contains(dataGridView1.CurrentRow.Cells["dogruCevap"].Value.ToString()))
            {
                radioButtonB.Checked = true;
            }

            else if (radioButtonC.Name.Contains(dataGridView1.CurrentRow.Cells["dogruCevap"].Value.ToString()))
            {
                radioButtonC.Checked = true;
            }

            else if (radioButtonD.Name.Contains(dataGridView1.CurrentRow.Cells["dogruCevap"].Value.ToString()))
            {
                radioButtonD.Checked = true;
            }

            else if (radioButtonE.Name.Contains(dataGridView1.CurrentRow.Cells["dogruCevap"].Value.ToString()))
            {
                radioButtonE.Checked = true;
            }
        }
    }
}
