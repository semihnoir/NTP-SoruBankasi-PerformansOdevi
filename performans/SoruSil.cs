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

        private void button1_Click(object sender, EventArgs e)
        {
            SoruBankasi soru = new SoruBankasi();
            string indexSil = textBoxSil.Text = listBox1.Text;
            soru.sorular.Remove(indexSil);
            soru.SilListele();
        }
    }
}
