using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Kiralama
{
    public partial class car_new : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        public car_new()
        {
            InitializeComponent();
        }
        private void car_new_Load(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlCommand cmd;
            SqlDataReader dr;
            DataView dv;
            string connetionString;

            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";
            cnn = new SqlConnection(connetionString);

            cmd = new SqlCommand("SELECT plate, km, brand, model, year, color, type, hp, gear, fuel, cost_per_day FROM car ", cnn);
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();

            da.Fill(dt);
            this.dataGridView1.Visible = true;
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["plate"].HeaderText = "Plaka";
             dataGridView1.Columns["km"].HeaderText = "Kilometre";
             dataGridView1.Columns["brand"].HeaderText = "Marka";
             dataGridView1.Columns["model"].HeaderText = "Model";
             dataGridView1.Columns["year"].HeaderText = "Araç Yılı";
             dataGridView1.Columns["color"].HeaderText = "Renk";
             dataGridView1.Columns["type"].HeaderText = "Araç Türü";
             dataGridView1.Columns["hp"].HeaderText = "Motor Gücü";
             dataGridView1.Columns["gear"].HeaderText = "Vites";
             dataGridView1.Columns["fuel"].HeaderText = "Yakıt Türü";
             dataGridView1.Columns["cost_per_day"].HeaderText = "Günlük Kiralama Ücreti";


            cnn.Close();
        }
        private void PopulateGridView()
        {
            SqlConnection cnn;
            SqlCommand cmd;
            SqlDataReader dr;
            DataView dv;
            string connetionString;

            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";
            cnn = new SqlConnection(connetionString);

            cmd = new SqlCommand("SELECT plate, km, brand, model, year, color, type, hp, gear, fuel, cost_per_day FROM car ", cnn);
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.Visible = true;
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["plate"].HeaderText = "Plaka";
            dataGridView1.Columns["km"].HeaderText = "Kilometre";
            dataGridView1.Columns["brand"].HeaderText = "Marka";
            dataGridView1.Columns["model"].HeaderText = "Model";
            dataGridView1.Columns["year"].HeaderText = "Araç Yılı";
            dataGridView1.Columns["color"].HeaderText = "Renk";
            dataGridView1.Columns["type"].HeaderText = "Araç Türü";
            dataGridView1.Columns["hp"].HeaderText = "Motor Gücü";
            dataGridView1.Columns["gear"].HeaderText = "Vites";
            dataGridView1.Columns["fuel"].HeaderText = "Yakıt Türü";
            dataGridView1.Columns["cost_per_day"].HeaderText = "Günlük Kiralama Ücreti";


            cnn.Close();
        }
        private void create_button_Click(object sender, EventArgs e)
        {
            string connetionString = ("Server=localhost;Database=master; Trusted_Connection=True");
            cnn = new SqlConnection(connetionString);

            if (plate_textbox.Text != string.Empty && km_textbox.Text != string.Empty && cmb_brand.Text != string.Empty && model_textbox.Text != string.Empty && year_textbox.Text != string.Empty && cmb_color.Text != string.Empty && cmb_type.Text != string.Empty && hp_textbox.Text != string.Empty && cmb_gear.Text != string.Empty && cmb_fuel.Text != string.Empty && costperday_textbox.Text != string.Empty)
            {
                cnn.Open();
                cmd = new SqlCommand("select * from car where plate = '" + plate_textbox.Text + "'", cnn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Bu plakaya sahip araba zaten kayıtlıdır.");
                }
                else
                {
                    cnn.Close();
                    cnn.Open();
                    cmd = new SqlCommand("insert into car (plate, km, brand, model, year, color, type, hp, gear, fuel, cost_per_day) values ('" + plate_textbox.Text + "', '" + km_textbox.Text + "',  '" + cmb_brand.Text + "', '" + model_textbox.Text + "', '" + year_textbox.Text + "', '" + cmb_color.Text + "', '" + cmb_type.Text + "', '" + hp_textbox.Text + "', '" + cmb_gear.Text + "', '" + cmb_fuel.Text + "', '" + costperday_textbox.Text + "')", cnn);
                    cmd.ExecuteNonQuery();
                    foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                    PopulateGridView();
                    MessageBox.Show(" Araç kaydı oluşturulmuştur.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string connetionString = ("Server=localhost;Database=master; Trusted_Connection=True");
            cnn = new SqlConnection(connetionString);

            if (plate_textbox.Text != string.Empty && km_textbox.Text != string.Empty && cmb_brand.Text != string.Empty && model_textbox.Text != string.Empty && year_textbox.Text != string.Empty && cmb_color.Text != string.Empty && cmb_type.Text != string.Empty && hp_textbox.Text != string.Empty && cmb_gear.Text != string.Empty && cmb_fuel.Text != string.Empty && costperday_textbox.Text != string.Empty)
            {
                cnn.Close();
                cnn.Open();
                cmd = new SqlCommand("UPDATE car SET plate = '" + plate_textbox.Text + "', km = '" + km_textbox.Text + "', brand = '" + cmb_brand.SelectedItem.ToString() + "', model = '" + model_textbox.Text + "', year = '" + year_textbox.Text + "', color = '" + cmb_color.SelectedItem.ToString() + "', type = '" + cmb_type.SelectedItem.ToString() + "', hp = '" + hp_textbox.Text + "', gear = '" + cmb_gear.SelectedItem.ToString() + "', fuel = '" + cmb_fuel.SelectedItem.ToString() + "', cost_per_day = '" + costperday_textbox.Text + "' WHERE plate = '" + plate_textbox.Text + "' ", cnn);
                cmd.ExecuteNonQuery();
                PopulateGridView();
                MessageBox.Show(" Araç başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string cost_per_day = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                string plate = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string km = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string brand = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string model = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string year = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string color = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string type = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string hp = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                string gear = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                string fuel = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

                costperday_textbox.Text = (cost_per_day).ToString();
                plate_textbox.Text = plate;
                km_textbox.Text = km;
                cmb_brand.Text = brand;
                model_textbox.Text = model;
                year_textbox.Text = year;
                cmb_color.Text = color;
                cmb_type.Text = type;
                hp_textbox.Text = hp;
                cmb_gear.Text = gear;
                cmb_fuel.Text = fuel;
            }
            else
            {
                costperday_textbox.Text = "";
                plate_textbox.Text = "";
                km_textbox.Text = "";
                cmb_brand.Text = "";
                model_textbox.Text = "";
                year_textbox.Text = "";
                cmb_color.Text = "";
                cmb_type.Text = "";
                hp_textbox.Text = "";
                cmb_gear.Text = "";
                cmb_fuel.Text = "";

            }
        }
    }
}
