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
using MySql;
using MySql.Data.MySqlClient;

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
        public static int sayac = 1;

        DB db = new DB();
        MySqlConnection baglanti;
        MySqlCommand cmdS;
        MySqlCommand cmdC;
        string komut_soru;
        string komut_cevap;

        private void SoruBankasi_Load(object sender, EventArgs e)
        {
            baglanti = db.baglan();

            string komut_soruSayisi = "SELECT COUNT(*) FROM sorular";
            MySqlCommand command = new MySqlCommand(komut_soruSayisi, baglanti);

            sayac = Convert.ToInt32(command.ExecuteScalar()) + 1;

            string soru = "SELECT soru_metni FROM sorular WHERE soru_id = @id";
            MySqlCommand cmd = new MySqlCommand(soru, baglanti);
            cmd.Parameters.AddWithValue("@id", 1);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    richTextBoxCsoru.Text = reader.GetString(0);
                }
            }

            string cevap = "SELECT cevap FROM cevaplar WHERE cevap_id = @id";
            cmd = new MySqlCommand(cevap, baglanti);
            cmd.Parameters.AddWithValue("@id", 1);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    richTextBoxsorucevaplari.Text = reader.GetString(0);
                }
            }

            string soruno = "SELECT soru_no FROM sorular WHERE soru_id = @id";
            cmd = new MySqlCommand(soruno, baglanti);
            cmd.Parameters.AddWithValue("@id", 1);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    labelSoru.Text = reader.GetString(0) + ".Soru";
                }
            }

            string dogruCevap = "SELECT dogruCevap FROM cevaplar WHERE cevap_id = @id";
            cmd = new MySqlCommand(dogruCevap, baglanti);
            cmd.Parameters.AddWithValue("@id", 1);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    labelDogru.Text = "Doğru Cevap: " + reader.GetString(0);
                }
            }

            SorulariEkle();
            CevaplariEkle();
        }

        public Dictionary<string,string> SorulariEkle()
        {
            string soruEkle = "SELECT soru_metni,cevap FROM sorular,cevaplar";
            MySqlCommand cmd = new MySqlCommand(soruEkle, baglanti);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    string anahtar = reader.GetString("soru_metni");
                    string deger = reader.GetString("cevap");
                    sorular[anahtar] = deger;
                }
                return sorular;
            }
        }

        public Dictionary<int,string> CevaplariEkle()
        {
            string cevapEkle = "SELECT cevap_id,dogruCevap FROM cevaplar";
            MySqlCommand cmd = new MySqlCommand(cevapEkle, baglanti);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    int anahtar = (int)reader["cevap_id"];
                    string deger = reader.GetString("dogruCevap");
                    cevaplar[anahtar] = deger;
                }
                return cevaplar;
            }
        }

        public void btnSoruEkle_Click(object sender, EventArgs e) // bu butona basıldığında dictinonary'e soru ve cevabı ekler.
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }

            komut_soru = "insert into sorular(soru_id,soru_no,soru_metni) values(@sid,@sno,@soruMetni)";
            komut_cevap = "insert into cevaplar(cevap_id,soru_id,dogruCevap,cevap,a,b,c,d,e) values(@cid,@sid,@dogru,@cevap,@a,@b,@c,@d,@e)";

            string soru = richTextBoxSoru.Text;
            string cevap = richTextBoxcevaplar.Lines[0] + Environment.NewLine + richTextBoxcevaplar.Lines[1] + Environment.NewLine + richTextBoxcevaplar.Lines[2] + Environment.NewLine + richTextBoxcevaplar.Lines[3] + Environment.NewLine + richTextBoxcevaplar.Lines[4];

            cmdS = new MySqlCommand(komut_soru, baglanti);
            cmdC = new MySqlCommand(komut_cevap, baglanti);

            
            if (soru != "" && cevap != "")
            {
                if (rbA.Checked)
                {
                    cmdS.Parameters.AddWithValue("@sid", sayac);
                    cmdS.Parameters.AddWithValue("@sno", sayac);
                    cmdS.Parameters.AddWithValue("@soruMetni", soru);
                    cmdS.ExecuteNonQuery();

                    cmdC.Parameters.AddWithValue("@sid", sayac);
                    cmdC.Parameters.AddWithValue("@cid", sayac);
                    cmdC.Parameters.AddWithValue("@a", richTextBoxcevaplar.Lines[0].Replace("A)", "").ToString());
                    cmdC.Parameters.AddWithValue("@b", richTextBoxcevaplar.Lines[1].Replace("B)", "").ToString());
                    cmdC.Parameters.AddWithValue("@c", richTextBoxcevaplar.Lines[2].Replace("C)", "").ToString());
                    cmdC.Parameters.AddWithValue("@d", richTextBoxcevaplar.Lines[3].Replace("D)", "").ToString());
                    cmdC.Parameters.AddWithValue("@e", richTextBoxcevaplar.Lines[4].Replace("E)", "").ToString());
                    cmdC.Parameters.AddWithValue("@cevap", richTextBoxcevaplar.Lines[0] + Environment.NewLine + richTextBoxcevaplar.Lines[1] + Environment.NewLine + richTextBoxcevaplar.Lines[2] + Environment.NewLine + richTextBoxcevaplar.Lines[3] + Environment.NewLine + richTextBoxcevaplar.Lines[4]);
                    sayac++;

                    cmdC.Parameters.AddWithValue("@dogru", "A");
                    cmdC.ExecuteNonQuery();
                    sorular.Add(soru, cevap);
                    cevaplar.Add(soruIndex, harfler[0]);
                    soruIndex++;
                    SoruEkle();
                }

                else if (rbB.Checked)
                {
                    cmdS.Parameters.AddWithValue("@sid", sayac);
                    cmdS.Parameters.AddWithValue("@sno", sayac);
                    cmdS.Parameters.AddWithValue("@soruMetni", soru);
                    cmdS.ExecuteNonQuery();

                    cmdC.Parameters.AddWithValue("@sid", sayac);
                    cmdC.Parameters.AddWithValue("@cid", sayac);
                    cmdC.Parameters.AddWithValue("@a", richTextBoxcevaplar.Lines[0].Replace("A)", "").ToString());
                    cmdC.Parameters.AddWithValue("@b", richTextBoxcevaplar.Lines[1].Replace("B)", "").ToString());
                    cmdC.Parameters.AddWithValue("@c", richTextBoxcevaplar.Lines[2].Replace("C)", "").ToString());
                    cmdC.Parameters.AddWithValue("@d", richTextBoxcevaplar.Lines[3].Replace("D)", "").ToString());
                    cmdC.Parameters.AddWithValue("@e", richTextBoxcevaplar.Lines[4].Replace("E)", "").ToString());
                    cmdC.Parameters.AddWithValue("@cevap", richTextBoxcevaplar.Lines[0] + Environment.NewLine + richTextBoxcevaplar.Lines[1] + Environment.NewLine + richTextBoxcevaplar.Lines[2] + Environment.NewLine + richTextBoxcevaplar.Lines[3] + Environment.NewLine + richTextBoxcevaplar.Lines[4]);
                    sayac++;

                    cmdC.Parameters.AddWithValue("@dogru", "B");
                    cmdC.ExecuteNonQuery();
                    sorular.Add(soru, cevap);
                    cevaplar.Add(soruIndex, harfler[1]);
                    soruIndex++;
                    SoruEkle();
                }

                else if (rbC.Checked)
                {
                    cmdS.Parameters.AddWithValue("@sid", sayac);
                    cmdS.Parameters.AddWithValue("@sno", sayac);
                    cmdS.Parameters.AddWithValue("@soruMetni", soru);
                    cmdS.ExecuteNonQuery();

                    cmdC.Parameters.AddWithValue("@sid", sayac);
                    cmdC.Parameters.AddWithValue("@cid", sayac);
                    cmdC.Parameters.AddWithValue("@a", richTextBoxcevaplar.Lines[0].Replace("A)", "").ToString());
                    cmdC.Parameters.AddWithValue("@b", richTextBoxcevaplar.Lines[1].Replace("B)", "").ToString());
                    cmdC.Parameters.AddWithValue("@c", richTextBoxcevaplar.Lines[2].Replace("C)", "").ToString());
                    cmdC.Parameters.AddWithValue("@d", richTextBoxcevaplar.Lines[3].Replace("D)", "").ToString());
                    cmdC.Parameters.AddWithValue("@e", richTextBoxcevaplar.Lines[4].Replace("E)", "").ToString());
                    cmdC.Parameters.AddWithValue("@cevap", richTextBoxcevaplar.Lines[0] + Environment.NewLine + richTextBoxcevaplar.Lines[1] + Environment.NewLine + richTextBoxcevaplar.Lines[2] + Environment.NewLine + richTextBoxcevaplar.Lines[3] + Environment.NewLine + richTextBoxcevaplar.Lines[4]);
                    sayac++;

                    cmdC.Parameters.AddWithValue("@dogru", "C");
                    cmdC.ExecuteNonQuery();
                    sorular.Add(soru, cevap);
                    cevaplar.Add(soruIndex, harfler[2]);
                    soruIndex++;
                    SoruEkle();
                }

                else if (rbD.Checked)
                {
                    cmdS.Parameters.AddWithValue("@sid", sayac);
                    cmdS.Parameters.AddWithValue("@sno", sayac);
                    cmdS.Parameters.AddWithValue("@soruMetni", soru);
                    cmdS.ExecuteNonQuery();

                    cmdC.Parameters.AddWithValue("@sid", sayac);
                    cmdC.Parameters.AddWithValue("@cid", sayac);
                    cmdC.Parameters.AddWithValue("@a", richTextBoxcevaplar.Lines[0].Replace("A)", "").ToString());
                    cmdC.Parameters.AddWithValue("@b", richTextBoxcevaplar.Lines[1].Replace("B)", "").ToString());
                    cmdC.Parameters.AddWithValue("@c", richTextBoxcevaplar.Lines[2].Replace("C)", "").ToString());
                    cmdC.Parameters.AddWithValue("@d", richTextBoxcevaplar.Lines[3].Replace("D)", "").ToString());
                    cmdC.Parameters.AddWithValue("@e", richTextBoxcevaplar.Lines[4].Replace("E)", "").ToString());
                    cmdC.Parameters.AddWithValue("@cevap", richTextBoxcevaplar.Lines[0] + Environment.NewLine + richTextBoxcevaplar.Lines[1] + Environment.NewLine + richTextBoxcevaplar.Lines[2] + Environment.NewLine + richTextBoxcevaplar.Lines[3] + Environment.NewLine + richTextBoxcevaplar.Lines[4]);
                    sayac++;

                    cmdC.Parameters.AddWithValue("@dogru", "D");
                    cmdC.ExecuteNonQuery();
                    sorular.Add(soru, cevap);
                    cevaplar.Add(soruIndex, harfler[3]);
                    soruIndex++;
                    SoruEkle();
                }

                else if (rbE.Checked)
                {
                    cmdS.Parameters.AddWithValue("@sid", sayac);
                    cmdS.Parameters.AddWithValue("@sno", sayac);
                    cmdS.Parameters.AddWithValue("@soruMetni", soru);
                    cmdS.ExecuteNonQuery();

                    cmdC.Parameters.AddWithValue("@sid", sayac);
                    cmdC.Parameters.AddWithValue("@cid", sayac);
                    cmdC.Parameters.AddWithValue("@a", richTextBoxcevaplar.Lines[0].Replace("A)", "").ToString());
                    cmdC.Parameters.AddWithValue("@b", richTextBoxcevaplar.Lines[1].Replace("B)", "").ToString());
                    cmdC.Parameters.AddWithValue("@c", richTextBoxcevaplar.Lines[2].Replace("C)", "").ToString());
                    cmdC.Parameters.AddWithValue("@d", richTextBoxcevaplar.Lines[3].Replace("D)", "").ToString());
                    cmdC.Parameters.AddWithValue("@e", richTextBoxcevaplar.Lines[4].Replace("E)", "").ToString());
                    cmdC.Parameters.AddWithValue("@cevap", richTextBoxcevaplar.Lines[0] + Environment.NewLine + richTextBoxcevaplar.Lines[1] + Environment.NewLine + richTextBoxcevaplar.Lines[2] + Environment.NewLine + richTextBoxcevaplar.Lines[3] + Environment.NewLine + richTextBoxcevaplar.Lines[4]);
                    sayac++;

                    cmdC.Parameters.AddWithValue("@dogru", "E");
                    cmdC.ExecuteNonQuery();
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
            if (sorular.Count >= 2 || sayac >= 2)
            {

                labelDogru.Visible = true;
                buttonGeri.Enabled = false;
                tabControl1.SelectTab(tabPage2);
                panelSorular.Visible = true;

                string soru = "SELECT soru_metni FROM sorular WHERE soru_id = @id";
                MySqlCommand cmd = new MySqlCommand(soru, baglanti);
                cmd.Parameters.AddWithValue("@id", 1);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        richTextBoxCsoru.Text = reader.GetString(0);
                    }
                }

                string cevap = "SELECT cevap FROM cevaplar WHERE cevap_id = @id";
                cmd = new MySqlCommand(cevap, baglanti);
                cmd.Parameters.AddWithValue("@id", 1);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        richTextBoxsorucevaplari.Text = reader.GetString(0);
                    }
                }

                string soruno = "SELECT soru_no FROM sorular WHERE soru_id = @id";
                cmd = new MySqlCommand(soruno, baglanti);
                cmd.Parameters.AddWithValue("@id", 1);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        labelSoru.Text = reader.GetString(0) + ".Soru";
                    }
                }

                string dogruCevap = "SELECT dogruCevap FROM cevaplar WHERE cevap_id = @id";
                cmd = new MySqlCommand(dogruCevap, baglanti);
                cmd.Parameters.AddWithValue("@id", 1);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        labelDogru.Text = "Doğru Cevap: " + reader.GetString(0);
                    }
                }
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

            if (soruNo <= 0)
            {
                soruNo = 1;
                labelSoru.Text = soruNo + ". Soru";
            }


            if (soruNo >= (sayac - 1))
            {
                buttonileri.Enabled = false;
                buttonGeri.Enabled = true;
            }

            else
            {
                buttonileri.Enabled = true;
            }

            string soru = "SELECT soru_metni FROM sorular WHERE soru_id = @id";
            MySqlCommand cmd = new MySqlCommand(soru, baglanti);
            cmd.Parameters.AddWithValue("@id", soruNo);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    richTextBoxCsoru.Text = reader.GetString(0);
                }
            }

            string cevap = "SELECT cevap FROM cevaplar WHERE cevap_id = @id";
            cmd = new MySqlCommand(cevap, baglanti);
            cmd.Parameters.AddWithValue("@id", soruNo);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    richTextBoxsorucevaplari.Text = reader.GetString(0);
                }
            }

            string dogruCevap = "SELECT dogruCevap FROM cevaplar WHERE cevap_id = @id";
            cmd = new MySqlCommand(dogruCevap, baglanti);
            cmd.Parameters.AddWithValue("@id", soruNo);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    labelDogru.Text = "Doğru Cevap: " + reader.GetString(0);
                }
            }
        }

        private void buttonGeri_Click(object sender, EventArgs e) // bu butona basıldığında bir önceki soru ve cevaba geçer.
        {
            index--;
            buttonileri.Enabled = true;
            soruNo--;
            labelSoru.Text = soruNo + ". Soru"; // 1. soru 2. soru şeklinde gözükmesi açısından label ile soruNo değişkenini birleştirir.

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

            string soru = "SELECT soru_metni FROM sorular WHERE soru_id = @id";
            MySqlCommand cmd = new MySqlCommand(soru, baglanti);
            cmd.Parameters.AddWithValue("@id", soruNo);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    richTextBoxCsoru.Text = reader.GetString(0);
                }
            }

            string cevap = "SELECT cevap FROM cevaplar WHERE cevap_id = @id";
            cmd = new MySqlCommand(cevap, baglanti);
            cmd.Parameters.AddWithValue("@id", soruNo);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    richTextBoxsorucevaplari.Text = reader.GetString(0);
                }
            }

            string dogruCevap = "SELECT dogruCevap FROM cevaplar WHERE cevap_id = @id";
            cmd = new MySqlCommand(dogruCevap, baglanti);
            cmd.Parameters.AddWithValue("@id", soruNo);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    labelDogru.Text = "Doğru Cevap: " + reader.GetString(0);
                }
            }
        }

        private void btnTemizleCevaplar_Click(object sender, EventArgs e)
        {
            richTextBoxcevaplar.Text = "A) " + Environment.NewLine + "B) " + Environment.NewLine + "C) " + Environment.NewLine + "D) " + Environment.NewLine + "E) ";
        }

        private void buttonSoruTemizle_Click(object sender, EventArgs e)
        {
            richTextBoxSoru.Clear();
        }

        private void kaydet_Click(object sender, EventArgs e) // Kaydet'e tıklanınca sorular dosya olarak kaydedilir.
        {
            int soruNoTxt = 1;
            int cevapNo = 1;
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "Metin Dosyası | *.txt";
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

            string cevap = "delete FROM cevaplar";
            MySqlCommand cmd = new MySqlCommand(cevap, baglanti);
            cmd.ExecuteNonQuery();

            labelSoru.Text = "Soru";
            labelDogru.Text = "Doğru Seçenek:";

            sorular.Clear();
            cevaplar.Clear();

            string soru = "delete FROM sorular";
            cmd = new MySqlCommand(soru, baglanti);
            cmd.ExecuteNonQuery();
            richTextBoxCsoru.Clear();
            richTextBoxsorucevaplari.Clear();
            tabControl1.SelectTab(tabPage1);
        }

        private void SoruBankasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSoruDuzenle_Click(object sender, EventArgs e)
        {
            SoruDuzenle duzenle = new SoruDuzenle();
            duzenle.ShowDialog();
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            GirisYap gy = new GirisYap();
            gy.Show();
            this.Hide();
        }

        void SoruListele()
        {
            baglanti = db.baglan();

            string soru = "SELECT soru_metni FROM sorular WHERE soru_id = @id";
            MySqlCommand cmd = new MySqlCommand(soru, baglanti);
            cmd.Parameters.AddWithValue("@id", 1);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    richTextBoxCsoru.Text = reader.GetString(0);
                }
            }

            string cevap = "SELECT cevap FROM cevaplar WHERE cevap_id = @id";
            cmd = new MySqlCommand(cevap, baglanti);
            cmd.Parameters.AddWithValue("@id", 1);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    richTextBoxsorucevaplari.Text = reader.GetString(0);
                }
            }

            string soruno = "SELECT soru_no FROM sorular WHERE soru_id = @id";
            cmd = new MySqlCommand(soruno, baglanti);
            cmd.Parameters.AddWithValue("@id", 1);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    labelSoru.Text = reader.GetString(0) + ".Soru";
                }
            }

            string dogruCevap = "SELECT dogruCevap FROM cevaplar WHERE cevap_id = @id";
            cmd = new MySqlCommand(dogruCevap, baglanti);
            cmd.Parameters.AddWithValue("@id", 1);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    labelDogru.Text = "Doğru Cevap: " + reader.GetString(0);
                }
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            SoruListele();
        }
    }
}
