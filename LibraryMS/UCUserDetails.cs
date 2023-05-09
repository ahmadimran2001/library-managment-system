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
    public partial class UCUserDetails : UserControl
    {
        string rollNo, email, username;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        private void btnSearchRollNo_Click(object sender, EventArgs e)
        {
            if (txtRollNo.Text != string.Empty)
            {
                String id = txtRollNo.Text;
                cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cn.Open();
                cmd = new SqlCommand("select * from userDetails where rollno = '" + id + "'", cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtUsername.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    txtUsername.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Wrong Roll Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter a Roll Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public UCUserDetails()
        {
            InitializeComponent();
        }

        private void UCUserDetails_Load(object sender, EventArgs e)
        {
            
        }
    }
}
