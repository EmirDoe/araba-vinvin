using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
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

        public static string Session = "";
        public string GetSession()
        {
            return Session;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string connetionString;


            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";
            cnn = new SqlConnection(connetionString);

            if (username_textbox.Text != string.Empty && password_textbox.Text != string.Empty)
            {
                Session = username_textbox.Text;
                cnn.Open();
                cmd = new SqlCommand("SELECT * FROM [user] WHERE user_name='" + username_textbox.Text + "' AND password='" + password_textbox.Text + "'", cnn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    dr.Close();
                    this.Hide();

                    cmd = new SqlCommand("SELECT user_role FROM [user] WHERE user_name='" + username_textbox.Text + "' ", cnn);
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        bool user_role = dr.GetBoolean(0);

                        Home home = new Home(user_role.ToString());
                        home.ShowDialog();
                    }

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

        private void register_button_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            PrivateFontCollection Font = new PrivateFontCollection();
            Font.AddFontFile("Inter-SemiBold.ttf");
            foreach (Control item in this.Controls)
            {
                item.Font = new Font(Font.Families[0], 9, FontStyle.Regular);
            }
            username_textbox.Location = new Point(75, 149);
            password_textbox.Location = new Point(75, 193);
            password_textbox.Size = new Size(210, 33);
            username_textbox.Size = new Size(210, 33);

        }
    }

}
