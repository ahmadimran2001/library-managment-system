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
    public partial class login : Form
    {
        SqlConnection cn;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            register Register= new register();
            Register.ShowDialog();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void clodebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure You want to close the application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
            cn.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string u = txtusername.Text.ToString();
            string p = txtpassword.Text.ToString();
            cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
            cn.Open();
            if (u != string.Empty && p != string.Empty)
            {
                cmd = new SqlCommand("select * from userDetails where username='" + u + "' and password = '" + p + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    MainScreen mainScreen = new MainScreen();
                    mainScreen.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Wrong User Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
