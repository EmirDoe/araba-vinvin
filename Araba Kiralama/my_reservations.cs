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
    public partial class my_reservations : Form
    {
        public my_reservations()
        {
            InitializeComponent();
            
        }
        private void my_reservations_Load(object sender, EventArgs e)
        {
            active_reservation();
            past_reservation();
        }
        private void PopulateGridView(DataGridView datagrid, string date)
        {
            SqlConnection cnn;
            SqlCommand cmd;
            SqlDataReader dr;
            DataView dv;
            string connetionString;

            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";
            cnn = new SqlConnection(connetionString);

            string user_name = Login.Session;
            
            DateTime dateForCheck = DateTime.Now;
            string user_tc = reservation.FindUserTcNoByUsername(user_name);

            if (datagrid == dg_active)
            {
                cmd = new SqlCommand("SELECT duration FROM reservation WHERE tc_no = '" + user_tc + "' ", cnn);
                cnn.Open();
                int duration = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();
                dateForCheck = dateForCheck.AddDays(duration);

                cmd = new SqlCommand("SELECT tc_no, date, duration, car_plate FROM reservation WHERE tc_no = '" + user_tc + "' AND date < '" + dateForCheck + "' ", cnn);
            }
            else
            {
                cmd = new SqlCommand("SELECT duration FROM reservation WHERE tc_no = '" + user_tc + "' ", cnn);
                cnn.Open();
                int duration = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();
                dateForCheck = dateForCheck.AddDays(duration);

                cmd = new SqlCommand("SELECT tc_no, car_plate, duration, date FROM reservation WHERE tc_no = '" + user_tc + "' AND date > '" + dateForCheck + "' ", cnn);
            }

            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);

            datagrid.Visible = true;
            datagrid.DataSource = dt;

            datagrid.Columns["tc_no"].HeaderText = "Müşteri TC";
            datagrid.Columns["car_plate"].HeaderText = "Araç Plaka";
            datagrid.Columns["duration"].HeaderText = "Kiralama Süresi (Gün)";
            datagrid.Columns["date"].HeaderText = "Tarih";

            cnn.Close();
        }

        private void active_reservation()
        {
            PopulateGridView(dg_active, DateTime.Now.ToString("d/M/yyyy"));
        }

        private void past_reservation()
        {
            PopulateGridView(dg_past, DateTime.Now.ToString("d/M/yyyy"));
        }
    }
}
