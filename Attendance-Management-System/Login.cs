using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Attendance_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string connstring = "server=127.0.0.1;uid=root;pwd=20181024;database=attendance";
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string email = txt_email.Text.Trim();
            string password = txt_password.Text;

            string sql = "SELECT Email, Password FROM attendance.user WHERE email=@Email AND password=@Password";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Login Successful!");

                Main m = new Main();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials");
            }

            reader.Close();
            conn.Close();


        }
    }
}
