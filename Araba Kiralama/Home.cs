using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Araba_Kiralama
{
    public partial class Home : Form
    {
        private Form activeForm;
        
        public Home(string user_role)
        {
            InitializeComponent();
   
            if (user_role == "False")
            {
                car_edit.Visible = false;
                customer_edit.Visible = false;
                reservation_edit.Visible = false;
                invoice_edit.Visible = false;
            }
            
        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            userdisplay.Text = Login.Session;
        }
       
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.guna2Panel2.Controls.Add(childForm);
            this.guna2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new reservation());
        }
        private void reservation_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new reservation());
        }    
        private void home_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new my_reservations());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void invoice_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new invoice());
        }

        private void car_edit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new car_new());
        }

        private void invoice_edit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new invoice_edit());
        }

        private void customer_edit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new customer_edit());
        }

        private void reservation_edit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new reservation_edit());
        }
    }
}
