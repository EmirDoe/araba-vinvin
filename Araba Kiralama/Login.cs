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
    public partial class Login : Form
        
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
      
            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";
            cnn = new SqlConnection(connetionString);

            if (username_textbox.Text != string.Empty && password_textbox.Text != string.Empty)
            {
                cnn.Open();
                cmd = new SqlCommand("SELECT * FROM user WHERE user_name='" + username_textbox.Text + "' AND password='" + password_textbox.Text + "'", cnn);
                dr = cmd.ExecuteReader();
               
                if (dr.Read())
                {
                    
                    dr.Close();
                    this.Hide();
                        
                    cmd = new SqlCommand("SELECT user_role FROM user WHERE user_name='" + username_textbox.Text + "' ", cnn);
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        bool user_role = dr.GetBoolean(0);
                        MessageBox.Show(user_role.ToString());
                    }

                    Home home = new Home();
                    home.ShowDialog();


                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Hatalı şifre veya kullanıcı adı girdiniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               

             
                cnn.Close();
            }
            else
            {
                MessageBox.Show("Lütfen hem şifrenizi hem kullanıcı adınızı giriniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
