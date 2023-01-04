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
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
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
            string connetionString = ("Server=localhost;Database=master; Trusted_Connection=True");
            cnn = new SqlConnection(connetionString);

            if(txt_plaka.Text != string.Empty && txt_km.Text != string.Empty && txt_marka.Text != string.Empty && txt_model.Text != string.Empty && txt_yil.Text != string.Empty && txt_renk.Text != string.Empty && txt_tur.Text != string.Empty && txt_hp.Text != string.Empty && txt_vites.Text != string.Empty && txt_yakit.Text != string.Empty && txt_tuketim.Text != string.Empty )
            {
                cnn.Open();
                cmd = new SqlCommand("select * from car where plate = '" + txt_plaka.Text + "'", cnn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Bu plakaya sahip araba zaten kayıtlıdır.");
                }
                else
                {
                    cnn.Close();
                    cnn.Open();
                    cmd = new SqlCommand("insert into car (plate, km, brand, model, year, color, type, hp, gear, fuel, cost_per_km) values ('" + txt_plaka.Text + "', '" + txt_km.Text + "',  '"+ txt_marka.Text + "', '" + txt_model.Text + "', '" + txt_yil.Text + "', '" + txt_renk.Text + "', '"+ txt_tur.Text + "', '" + txt_hp.Text + "', '"+ txt_vites.Text + "', '" + txt_yakit.Text + "', '"+ txt_tuketim.Text + "')", cnn);
                    cmd.ExecuteNonQuery();
                    foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                    MessageBox.Show(" Araç kaydı oluşturulmuştur.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }

           /* dr.Close();
            cmd = new SqlCommand("insert into araba values ('" + txt_plaka.Text + "', '" + txt_km.Text + "', '"+ txt_kiralayan.Text +"', '"+ txt_marka.Text + "', '" + txt_model.Text + "', '" + txt_yil.Text + "', '" + txt_renk.Text + "', '"+ txt_tur.Text + "', '" + txt_hp.Text + "', '"+ txt_vites.Text + "', '" + txt_yakit.Text + "', '"+ txt_tuketim.Text + "', '" + txt_mevcut.Text + "')", cnn);
            cmd.ExecuteNonQuery();
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
            komut2.Parameters.AddWithValue("@availability", txt_mevcut.Text); */



            // foreach (Control item in Controls) if (item is TextBox) item.Text = "";


            
        }

        private void lb_vites_Click(object sender, EventArgs e)
        {

        }

        private void lb_model_Click(object sender, EventArgs e)
        {

        }

        private void lb_hp_Click(object sender, EventArgs e)
        {

        }

        private void lb_tur_Click(object sender, EventArgs e)
        {

        }

        private void lb_renk_Click(object sender, EventArgs e)
        {

        }

        private void lb_tuketim_Click(object sender, EventArgs e)
        {

        }

        private void lb_yil_Click(object sender, EventArgs e)
        {

        }

        private void lb_yakit_Click(object sender, EventArgs e)
        {

        }

        private void txt_vites_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_hp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_marka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_renk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tuketim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_yil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_yakit_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_marka_Click(object sender, EventArgs e)
        {

        }
    }
}
