using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Araba_Kiralama
{
    public partial class araba : Form
    {
        araba_ekleme araba_kiralama = new araba_ekleme();
        public araba()
        {
            InitializeComponent();
        }

        private void araba_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "instert into araba(plate,km,rented_by,brand,model,year,color,type,hp,gear,fuel,cost_per_km,availability) values (@plate,@km,@rented_by,@brand,@model,@year,@color,@type,@hp,@gear,@fuel,@cost_per_km,@availability)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plate", txt_plaka.Text);
            komut2.Parameters.AddWithValue("@km", txt_km.Text);
            komut2.Parameters.AddWithValue("@rented_by", txt_kiralayan.Text);
            komut2.Parameters.AddWithValue("@brand", txt_marka.Text);
            komut2.Parameters.AddWithValue("@model", txt_model.Text);
            komut2.Parameters.AddWithValue("@year", txt_yil.Text);
            komut2.Parameters.AddWithValue("@color", txt_renk.Text);
            komut2.Parameters.AddWithValue("@type", txt_tur.Text);
            komut2.Parameters.AddWithValue("@hp", txt_hp.Text);
            komut2.Parameters.AddWithValue("@gear", txt_vites.Text);
            komut2.Parameters.AddWithValue("@fuel", txt_yakit.Text);
            komut2.Parameters.AddWithValue("@cost_per_km", txt_tuketim.Text);
            komut2.Parameters.AddWithValue("@availability", txt_mevcut.Text);
            araba_kiralama.ekle_sil_guncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }
    }
}
