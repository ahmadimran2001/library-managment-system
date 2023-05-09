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

namespace LibraryMS
{
    public partial class register : Form
    {
        SqlConnection cn;
        string rollNo, eMail, userName;
        public register()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login Login = new login();
            Login.ShowDialog();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
            cn.Open();
            if (txtcpass.Text != string.Empty & txtpass.Text != string.Empty & txtusername.Text != string.Empty & txtemail.Text != string.Empty & txtrollno.Text != string.Empty)
            {
                SqlCommand cmd;
                if (txtpass.Text == txtcpass.Text)
                {
                    cmd = new SqlCommand("select * from userDetails where username='" + txtusername.Text
                    + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into userDetails values(@email,@rollno,@username, @password)", cn);
                        cmd.Parameters.AddWithValue("email", txtemail.Text);
                        cmd.Parameters.AddWithValue("rollno", txtrollno.Text);
                        cmd.Parameters.AddWithValue("username", txtusername.Text);
                        cmd.Parameters.AddWithValue("password", txtpass.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.","Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        login Login = new login();
                        Login.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
            cn.Open();
        }

        private void closebtn1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure You want to close the application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

}
