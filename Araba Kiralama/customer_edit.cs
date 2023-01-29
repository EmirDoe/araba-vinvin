using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Araba_Kiralama
{
    public partial class customer_edit : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        public customer_edit()
        {
            InitializeComponent();
        }
        public DataTable list(SqlDataAdapter adtr, string query)
        {
            SqlConnection conectionString = new SqlConnection("Server=localhost;Database=master; Trusted_Connection=True;");
            DataTable dt = new DataTable();
            adtr = new SqlDataAdapter(query, conectionString);
            adtr.Fill(dt);
            conectionString.Close();
            return dt;
        }
        private void customer_edit_Load(object sender, EventArgs e)
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

            cmd = new SqlCommand("SELECT tc_no, user_name, password, full_name, birth_date, phone_number FROM [user]", cnn);
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.dataGridView1.Visible = true;
            dataGridView1.DataSource = dt;
      
            dataGridView1.Columns["tc_no"].HeaderText = "Müşteri TC";
            dataGridView1.Columns["user_name"].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns["password"].HeaderText = "Şifre";
            dataGridView1.Columns["full_name"].HeaderText = "Ad Soyad";
            dataGridView1.Columns["birth_date"].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns["phone_number"].HeaderText = "Telefon Numarası";
            cnn.Close();

        }
        private void update_button_Click(object sender, EventArgs e)
        {
            string connetionString = ("Server=localhost;Database=master; Trusted_Connection=True");
            cnn = new SqlConnection(connetionString);

            if ( username_textbox.Text != string.Empty && pass_textbox.Text != string.Empty && tc_textbox.Text != string.Empty && name_textbox.Text != string.Empty && phone_textbox.Text != string.Empty && bday_date.Value.ToString() != string.Empty )
            {
                cnn.Close();
                cnn.Open();
                cmd = new SqlCommand("UPDATE [user] SET user_name = '" + username_textbox.Text + "', tc_no = '" + tc_textbox.Text + "', full_name = '" + name_textbox.Text + "', phone_number = '" + phone_textbox.Text + "', birth_date = '" + bday_date.Value.ToString() + "' WHERE tc_no = '" + tc_textbox.Text + "' ", cnn);
                cmd.ExecuteNonQuery();
                PopulateGridView();
                MessageBox.Show(" Müşteri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            if (username_textbox.Text != string.Empty && pass_textbox.Text != string.Empty && tc_textbox.Text != string.Empty && name_textbox.Text != string.Empty && phone_textbox.Text != string.Empty && bday_date.Value.ToString() != string.Empty)
            {
                cnn.Open();
                cmd = new SqlCommand("DELETE FROM [user] WHERE tc_no = '" + tc_textbox.Text + "'", cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                PopulateGridView();
                MessageBox.Show(" Müşteri başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir müşteri seçin.");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                string tc = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string username = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string password = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string bday = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string phone = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                tc_textbox.Text = tc;
                username_textbox.Text = username;
                pass_textbox.Text = password;
                name_textbox.Text = name;
                bday_date.Text = bday;
                phone_textbox.Text = phone;
            }
            else
            {
                tc_textbox.Text = "";
                username_textbox.Text = "";
                pass_textbox.Text = "";
                name_textbox.Text = "";
                bday_date.Text = "";
                phone_textbox.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cmd = "select tc_no,user_name,password,full_name,birth_date,phone_number from [user] WHERE (user_role = 0) AND tc_no like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = list(adtr2, cmd);
        }     
    }
}
