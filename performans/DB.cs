using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace performans
{
    class DB
    {
        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection("server=localhost; database=soruBankasi; Uid=root; Pwd=123456;"); // bağlantı bilgileri
            baglanti.Open(); // bağlantıyı aç
            MySqlConnection.ClearPool(baglanti); // önceki bağlantıları temizle
            return (baglanti); // bağlantıyı gönder
        }
    }
}
