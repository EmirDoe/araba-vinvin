﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Kiralama
{
    public partial class Register : Form
    {
        

        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlCommand cmd;
            SqlDataReader dr;

            string connetionString;
            connetionString = "Server=localhost;Database=master; Trusted_Connection=True;";

            cnn = new SqlConnection(connetionString);

            if (username_reg_textbox.Text != string.Empty && password_reg_textbox.Text != string.Empty && tc_textbox.Text != string.Empty && name_textbox.Text != string.Empty && phone_textbox.Text != string.Empty && bday_date.Value.ToString() != string.Empty)
            {
                cnn.Open();

                cmd = new SqlCommand("select * from customer where user_name='" + username_reg_textbox.Text + "'", cnn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Bu kullanıcı adı önceden kayıt edilmiş ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT INTO customer VALUES('" + tc_textbox.Text + "', '" + username_reg_textbox.Text + "', '" + password_reg_textbox.Text + "', '" + 0 + "', '" + name_textbox.Text + "' , '" + bday_date.Value.ToString() + "', '" + phone_textbox.Text + "',  '" + null + "')", cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hesabınız oluşturuldu, giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cnn.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurduğunuzdan emin olun ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, EventArgs e)
        {

        }
    }
}