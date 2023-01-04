using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Araba_Kiralama
{
    internal class araba_ekleme
    {
        SqlConnection baglanti = new SqlConnection("Server=localhost;Database=master; Trusted_Connection=True");
        DataTable tablo;
        public void ekle_sil_guncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
