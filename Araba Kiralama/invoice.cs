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
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Araba_Kiralama
{
    public partial class invoice : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        public invoice()
        {
            InitializeComponent();

        }
        private void PopulateGridView(DataGridView datagrid, int status)
        {
            SqlConnection cnn;
            SqlCommand cmd;
            SqlDataReader dr;
            DataView dv;
            string connetionString;

            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";
            cnn = new SqlConnection(connetionString);
            
            string user_name = Login.Session;
            cmd = new SqlCommand("SELECT [user].tc_no, car_plate,total,date,tax FROM [invoice] INNER JOIN [user] ON [user].tc_no=[invoice].tc_no WHERE (status = '" + status + "') AND [user].user_name='" + user_name + "'", cnn);
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);

            datagrid.Visible = true;
            datagrid.DataSource = dt;

            
            datagrid.Columns["tc_no"].HeaderText = "Müşteri TC";
            datagrid.Columns["car_plate"].HeaderText = "Araç Plaka";
            datagrid.Columns["total"].HeaderText = "Toplam Tutar";
            datagrid.Columns["date"].HeaderText = "Tarih";
            datagrid.Columns["tax"].HeaderText = "Vergi Oranı";

            cnn.Close();
        }
        private void unpaid_invoice()
        {
            PopulateGridView(dg_unpaid, 0);
        }
        private void paid_invoice()
        {
            PopulateGridView(dg_paid, 1);
        }
        private void fatura_Load(object sender, EventArgs e)
        {
            unpaid_invoice();
            paid_invoice();
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlCommand cmd;
            SqlDataReader dr;
            DataView dv;
            string connetionString;

            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";
            cnn = new SqlConnection(connetionString);

            string user_name = Login.Session;
            if (dg_unpaid.SelectedRows.Count == 1)
            {
                string tc = dg_unpaid.SelectedRows[0].Cells[0].Value.ToString();
                string plate = dg_unpaid.SelectedRows[0].Cells[1].Value.ToString();
                string total = dg_unpaid.SelectedRows[0].Cells[2].Value.ToString();
                string date = dg_unpaid.SelectedRows[0].Cells[3].Value.ToString();
                string tax = dg_unpaid.SelectedRows[0].Cells[4].Value.ToString();
                cmd = new SqlCommand(" UPDATE [invoice] SET status = 1 WHERE tc_no = '" + tc + "' AND car_plate = '" + plate + "' AND total = '" + total + "' AND date = '" + date + "' AND tax = '" + tax + "'", cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                unpaid_invoice();
                paid_invoice();
                MessageBox.Show("Fatura Ödendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen ödenecek faturayı seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
