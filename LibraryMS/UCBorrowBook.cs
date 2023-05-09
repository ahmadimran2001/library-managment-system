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
    public partial class UCBorrowBook : UserControl
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter da;
        DataSet ds;
        public UCBorrowBook()
        {
            InitializeComponent();
        }

        private void UCBorrowBook_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cn.Open();
            cmd = new SqlCommand("select bname from add_book",cn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    comboBooks.Items.Add(dataReader.GetString(i));
                }
            }
            dataReader.Close();
            cn.Close();
        }

        private void btnSearchRollNo_Click(object sender, EventArgs e)
        {
            if (txtRollNo.Text != string.Empty)
            {
                String id = txtRollNo.Text;
                cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cn.Open();
                cmd = new SqlCommand("select * from userDetails where rollno = '"+id+"'",cn);
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
                    MessageBox.Show("Wrong Roll Number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter a Roll Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty)
            {
                if (comboBooks.SelectedIndex != -1)
                {
                    cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
                    cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cn.Open();
                    cmd = new SqlCommand("insert into bReturn values('" + txtRollNo.Text + "','" + txtUsername.Text + "','" + txtEmail.Text + "','"+comboBooks.Text+"')", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select a book to borrow", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter a Roll Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRollNo_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtEmail.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtRollNo.Clear();
        }
    }
}
