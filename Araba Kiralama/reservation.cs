using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Araba_Kiralama
{
    public partial class reservation : Form
    {
        public string Session { get; private set; }

        public reservation()
        {
            InitializeComponent();

        }

        private void kiralama_Load(object sender, EventArgs e)
        {

            SqlConnection cnn;
            SqlCommand cmd;
            SqlDataReader dr;
            DataView dv;
            string connetionString;

            ClearFilters();

            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";
            cnn = new SqlConnection(connetionString);

            cmd = new SqlCommand("SELECT plate, km, brand, model, year, color, type, hp, gear, fuel, cost_per_day FROM car WHERE (availability =  1) ", cnn);
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


            cmd = new SqlCommand("SELECT DISTINCT brand FROM car ", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_brand.Items.Add(dr["brand"]);
            }
            dr.Close();

            cmd = new SqlCommand("SELECT DISTINCT type FROM car ", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_type.Items.Add(dr["type"]);
            }
            dr.Close();

            cmd = new SqlCommand("SELECT DISTINCT gear FROM car ", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_gear.Items.Add(dr["gear"]);
            }

            dr.Close();

            cmd = new SqlCommand("SELECT DISTINCT fuel FROM car ", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_fuel.Items.Add(dr["fuel"]);
            }
            dr.Close();

            cmd = new SqlCommand("SELECT DISTINCT color FROM car ", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_color.Items.Add(dr["color"]);
            }
            dr.Close();

            cnn.Close();

        }
        private void ClearFilters()
        {
            cmb_brand.SelectedIndex = 0;
            cmb_color.SelectedIndex = 0;
            cmb_fuel.SelectedIndex = 0;
            cmb_gear.SelectedIndex = 0;
            cmb_type.SelectedIndex = 0;
            km_min_textbox.Text = "min";
            km_max_textbox.Text = "max";
        }

        private void PopulateDataGridView(Dictionary<string, string> QueryList)
        {
            SqlConnection cnn;
            SqlDataReader dr;
            DataView dv;


            string connetionString;
            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";

            string query = "SELECT plate, km, brand, model, year, color, type, hp, gear, fuel, cost_per_day FROM car WHERE (availability =  1) ";


            if (QueryList.Count != 0)
            {
                var last = QueryList.Values.Last();
                query += "WHERE";


                foreach (KeyValuePair<string, string> Query in QueryList)
                {

                    if (Query.Value == last)
                    {
                        if (Query.Key == "km_min")
                        {
                            query += "  km > " + Query.Value + " ";
                        }
                        else if (Query.Key == "km_max")
                        {
                            query += "  km  <  " + Query.Value + " ";
                        }
                        else
                        {
                            query += "  " + Query.Key + " = '" + Query.Value + "'";
                        }
                    }
                    else if (Query.Key == "km_min")
                    {
                        query += "  km  > " + Query.Value + " AND";
                    }
                    else if (Query.Key == "km_max")
                    {
                        query += "  km  <  " + Query.Value + " AND";
                    }

                    else
                    {
                        query += "  " + Query.Key + " = '" + Query.Value + "' AND";
                    }
                }
            }


            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand(query, con);

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
            
        }

        public static string FindUserTcNoByUsername(string username)
        {
            string connetionString;
            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";

            string tcnoquery = "SELECT tc_no FROM [user] WHERE user_name = '" + username + "' ";

            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand(tcnoquery, con);

            con.Open();
            string tcno = cmd.ExecuteScalar().ToString();
            con.Close();

            return tcno;
        }
        private static int GetTax()
        {
            return 18;
        }
        private void RentCar(string username, string plate)
        {
            string connetionString;
            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";

            string tcno = FindUserTcNoByUsername(username);
            string userquery = "UPDATE [user] SET rented_car = '"+ plate +"' WHERE user_name = '" + username + "' ";
            string carquery = "UPDATE car SET availability = 0, rented_by = '" + tcno +  "' WHERE plate = '" + plate + "' ";

            SqlConnection con = new SqlConnection(connetionString);
          
            SqlCommand cmd = new SqlCommand(userquery, con);
            SqlCommand cmd2 = new SqlCommand(carquery, con);
            
            con.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
        }
        

        private void CreateReservation(string username, string plate, string duration)
        {
            string connetionString;
            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";
            string tc_no = FindUserTcNoByUsername(username);

            string query = "INSERT INTO reservation (tc_no ,car_plate, duration, status, date) VALUES ('" + tc_no + "' , '" + plate + "', '" + duration + "', '0', GETDATE())";
            string idquery = "SELECT @@IDENTITY";

            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd2 = new SqlCommand(idquery, con);
            
            con.Open();
            cmd.ExecuteNonQuery();
            string id = cmd2.ExecuteScalar().ToString();
            con.Close();
            
            CreateInvoice(id, tc_no, plate, totalcost_textbox.Text);
        }
        private void CreateInvoice(string id, string tc_no, string plate, string cost)
        {
            string connetionString;
            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";

            int tax = GetTax();
            double dbtotalcost = (double.Parse(cost) * 1.18);
            int roundedcost = (int)Math.Round(dbtotalcost);
            string totalcost = roundedcost.ToString();


            string query = "INSERT INTO invoice (reservation_id, tc_no, car_plate, total, tax, status, date) VALUES ('" + id + "', '" + tc_no + "' , '" + plate + "', '" + totalcost + "', '" + tax + "', '0' ,GETDATE())";

            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearFilters();
            var empty = new Dictionary<string, string>();
            PopulateDataGridView(empty);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (rentduration_textbox.Text.Trim() == string.Empty)
                {
                    rentduration_textbox.Text = "1";
                }

                string cost_per_day = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                string rent_duration = rentduration_textbox.Text.ToString();
                string plate = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                costperday_textbox.Text = (cost_per_day).ToString();
                plate_textbox.Text = plate;
                if (rent_duration != string.Empty && cost_per_day != string.Empty)
                {
                    int cost = Convert.ToInt32(cost_per_day) * Convert.ToInt32(rent_duration);
                    totalcost_textbox.Text = cost.ToString();
                }
                else
                {
                    rentduration_textbox.Text = "";
                    totalcost_textbox.Text = "";
                    costperday_textbox.Text = "";
                    plate_textbox.Text = "";
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            Session = login.GetSession();
            if(rentduration_textbox.Text != string.Empty && costperday_textbox.Text != string.Empty && plate_textbox.Text != string.Empty && totalcost_textbox.Text != string.Empty && Session != null )
            {
                RentCar(Session, plate_textbox.Text);
                CreateReservation(Session, plate_textbox.Text, rentduration_textbox.Text);
                MessageBox.Show("Araç Kiralandı");
            }
            else
            {
                MessageBox.Show("Lütfen Kiralama İçin Gerekli Bütün Alanları Doldurun.");
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            var queries = new Dictionary<string, string>();


            if (cmb_brand.SelectedIndex != -1 && cmb_brand.SelectedIndex != 0)
            {
                queries.Add("brand", cmb_brand.SelectedItem.ToString());
            }

            if (cmb_fuel.SelectedIndex != -1 && cmb_fuel.SelectedIndex != 0)
            {
                queries.Add("fuel", cmb_fuel.SelectedItem.ToString());

            }

            if (cmb_color.SelectedIndex != -1 && cmb_color.SelectedIndex != 0)
            {
                queries.Add("color", cmb_color.SelectedItem.ToString());

            }

            if (cmb_type.SelectedIndex != -1 && cmb_type.SelectedIndex != 0)
            {
                queries.Add("type", cmb_type.SelectedItem.ToString());

            }

            if (cmb_gear.SelectedIndex != -1 && cmb_gear.SelectedIndex != 0)
            {
                queries.Add("gear", cmb_gear.SelectedItem.ToString());

            }

            if (km_min_textbox.Text.Trim() != string.Empty && IsDigitsOnly(km_min_textbox.Text))
            {
                queries.Add("km_min", km_min_textbox.Text);

            }
            if (km_max_textbox.Text.Trim() != string.Empty && IsDigitsOnly(km_max_textbox.Text))
            {
                queries.Add("km_max", km_max_textbox.Text);

            }

            PopulateDataGridView(queries);
        }

        private void clean_Button_Click(object sender, EventArgs e)
        {
            ClearFilters();
            var empty = new Dictionary<string, string>();
            PopulateDataGridView(empty);
        }


        private void rent_button_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Session = login.GetSession();
            if (rentduration_textbox.Text != string.Empty && costperday_textbox.Text != string.Empty && plate_textbox.Text != string.Empty && totalcost_textbox.Text != string.Empty && Session != null)
            {
                RentCar(Session, plate_textbox.Text);
                CreateReservation(Session, plate_textbox.Text, rentduration_textbox.Text);
                var empty = new Dictionary<string, string>();
                PopulateDataGridView(empty);
                MessageBox.Show("Araç Kiralandı");
            }
            else
            {
                MessageBox.Show("Lütfen Kiralama İçin Gerekli Bütün Alanları Doldurun.");
            }
        }
    }
}
