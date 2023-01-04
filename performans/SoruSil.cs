using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performans
{
    public partial class SoruSil : Form
    {
        public SoruSil()
        {
            InitializeComponent();
        }

        SoruBankasi soru = new SoruBankasi();
        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBoxSorular.SelectedIndex;
            string sil = textBoxSil.Text;
            SoruBankasi.sorular.Remove(sil);
            SoruBankasi.cevaplar.Remove(index);
            listBoxSorular.Items.Clear();
            foreach (var ekle in SoruBankasi.sorular)
            {
                listBoxSorular.Items.Add(ekle.Key);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSil.Text = listBoxSorular.Text;
        }
    }
}
