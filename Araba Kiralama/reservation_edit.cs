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
    public partial class reservation_edit : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public reservation_edit()
        {
            InitializeComponent();
        }

        private void reservation_edit_Load(object sender, EventArgs e)
        {
            PopulateGridView();
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

            cmd = new SqlCommand("SELECT id, car_plate, tc_no, date, duration, status  FROM reservation ", cnn);
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.dataGridView1.Visible = true;
            dataGridView1.DataSource = dt;


            dataGridView1.Columns["id"].HeaderText = "Fatura No";
            dataGridView1.Columns["car_plate"].HeaderText = "Plaka";
            dataGridView1.Columns["tc_no"].HeaderText = "Müşteri TC";
            dataGridView1.Columns["date"].HeaderText = "Tarih";
            dataGridView1.Columns["duration"].HeaderText = "Süre";
            dataGridView1.Columns["status"].HeaderText = "Durum";

            cnn.Close();
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            string connetionString = ("Server=localhost;Database=master; Trusted_Connection=True");
            cnn = new SqlConnection(connetionString);

            if (plate_textbox.Text != string.Empty && tc_text.Text != string.Empty && reservation_date.Text != string.Empty && reservation_textbox.Text != string.Empty && cmb_status.Text != string.Empty)
            {
                int status = 0;
                if (cmb_status.SelectedItem == "Aktif")
                {
                    status = 1;
                }
                else
                {
                    status = 0;
                }
                cnn.Close();
                cnn.Open();
                cmd = new SqlCommand("UPDATE reservation SET car_plate = '" + plate_textbox.Text + "', tc_no = '" + tc_text.Text + "', date = '" + reservation_date.Value.ToString() + "', duration = '" + reservation_textbox.Text + "', status = '" + status + "' WHERE id = '" + res_id.Text + "' ", cnn);
                cmd.ExecuteNonQuery();
                PopulateGridView();
                MessageBox.Show(" Rezervasyon başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            string connetionString = ("Server=localhost;Database=master; Trusted_Connection=True");
            cnn = new SqlConnection(connetionString);

            if (plate_textbox.Text != string.Empty && tc_text.Text != string.Empty && reservation_date.Text != string.Empty && reservation_textbox.Text != string.Empty && cmb_status.Text != string.Empty)
            {
                cnn.Close();
                cnn.Open();
                cmd = new SqlCommand("DELETE FROM reservation WHERE id = '" + res_id.Text + "'", cnn);
                cmd.ExecuteNonQuery();
                PopulateGridView();
                MessageBox.Show(" Rezervasyon başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir rezervasyon seçin.");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string plate = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string tc = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string date = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string duration = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "True")
                {
                    cmb_status.SelectedItem = "Aktif";
                }
                else
                {
                    cmb_status.SelectedItem = "Geçmiş";
                }

                res_id.Text = id;
                plate_textbox.Text = plate;
                tc_text.Text = tc;
                reservation_date.Text = date;
                reservation_textbox.Text = duration;

            }
            else
            {
                cmb_status.Text = "";
                res_id.Text = "";
                plate_textbox.Text = "";
                tc_text.Text = "";
                reservation_date.Text = "";
                reservation_textbox.Text = "";
                
            }
        }

    }
}
