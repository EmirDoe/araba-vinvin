using iTextSharp.text.pdf;
using iTextSharp.text;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Araba_Kiralama
{
    public partial class invoice_edit : Form
    {

        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        
        public invoice_edit()
        {
            InitializeComponent();
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

            cmd = new SqlCommand("SELECT id, car_plate, tc_no, date, total, reservation_id, status, tax FROM invoice ", cnn);
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
            dataGridView1.Columns["total"].HeaderText = "Toplam";
            dataGridView1.Columns["reservation_id"].HeaderText = "Rezervasyon ID";
            dataGridView1.Columns["status"].HeaderText = "Durum";
            dataGridView1.Columns["tax"].HeaderText = "Vergi";

            cnn.Close();
        }
        private void fatura_duzenleme_Load(object sender, EventArgs e)
        {
            PopulateGridView();

        }
        private void update_button_Click(object sender, EventArgs e)
        {
            string connetionString = ("Server=localhost;Database=master; Trusted_Connection=True");
            cnn = new SqlConnection(connetionString);

            if (plate_textbox.Text != string.Empty && invoice_textbox.Text != string.Empty && tc_text.Text != string.Empty && invoice_date.Text != string.Empty && total_textbox.Text != string.Empty && reservation_textbox.Text != string.Empty && cmb_status.Text != string.Empty && tax_textbox.Text != string.Empty)
            {
                int status = 0;
                if(cmb_status.SelectedItem == "Ödendi")
                {
                     status = 1;
                }
                else
                {
                     status = 0;
                }
                cnn.Close();
                cnn.Open();
                cmd = new SqlCommand("UPDATE invoice SET car_plate = '" + plate_textbox.Text + "', tc_no = '" + tc_text.Text + "', date = '" + invoice_date.Value.ToString() + "', total = '" + total_textbox.Text + "', reservation_id = '" + reservation_textbox.Text + "', tax = '" + tax_textbox.Text + "', status = '" + status + "' WHERE id = '" + invoice_textbox.Text + "' ", cnn);
                cmd.ExecuteNonQuery();
                PopulateGridView();
                MessageBox.Show(" Fatura başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            if (plate_textbox.Text != string.Empty && invoice_textbox.Text != string.Empty && tc_text.Text != string.Empty && invoice_date.Text != string.Empty && total_textbox.Text != string.Empty && reservation_textbox.Text != string.Empty && cmb_status.Text != string.Empty && tax_textbox.Text != string.Empty)
            {
                cnn.Close();
                cnn.Open();
                cmd = new SqlCommand("DELETE FROM invoice WHERE id = '" + invoice_textbox.Text + "'", cnn);
                cmd.ExecuteNonQuery();
                PopulateGridView();
                MessageBox.Show(" Fatura başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir fatura seçin.");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string invoice = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string plate = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string tc = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string date = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells[6].Value.ToString() == "True")
                {
                    cmb_status.SelectedItem = "Ödendi";
                }
                else
                {
                    cmb_status.SelectedItem = "Ödenmedi"; 
                }

                string total = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string reservation = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string tax = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                
                
                plate_textbox.Text = plate;
                invoice_textbox.Text = invoice;
                tc_text.Text = tc;
                invoice_date.Text = date;
                total_textbox.Text = total;
                tax_textbox.Text = tax;
                reservation_textbox.Text = reservation;
            }
            else
            {
                plate_textbox.Text = "";
                invoice_textbox.Text = "";
                tc_text.Text = "";
                invoice_date.Text = "";
                total_textbox.Text = "";
                cmb_status.Text = "";
                tax_textbox.Text = "";
                reservation_textbox.Text = "";
            }
        }
        
        private void arama_textbox_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select id,tc_no,car_plate,total,date,status,tax,reservation_id from [invoice] WHERE tc_no like '%" + arama_textbox.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            //dataGridView1.DataSource = listele(adtr2, cumle);
        }

       
        private void btn_print2pdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "PDF Çıktısı.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Veriler diske yazılamaz!" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Veriler başarıyla aktarıldı!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Aktarılacak bir veri yok!", "Info");
            }
        }

        
    }
}
