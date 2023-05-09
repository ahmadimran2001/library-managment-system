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
    public partial class UCAddBook : UserControl
    {
        SqlConnection cn;
        SqlCommand cmd;
        public UCAddBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UCAddBook_Load(object sender, EventArgs e)
        {

        }

        // save button
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != string.Empty && txtAuthorName.Text != string.Empty && txtDescription.Text != string.Empty && txtCategory.Text != string.Empty && txtQuantity.Text != string.Empty)
            {
                String bookName = txtBookName.Text;
                String authorName = txtAuthorName.Text;
                String description = txtDescription.Text;
                String category = txtCategory.Text;
                String quantity = txtQuantity.Text;

                cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cn.Open();
                cmd = new SqlCommand("insert into add_book (bname,aname,bdesc,category,quantity) values ('" + txtBookName.Text + "','" + txtAuthorName.Text + "','" + txtDescription.Text + "','" + txtCategory.Text + "','" + txtQuantity.Text + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Book Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthorName.Clear();
                txtDescription.Clear();
                txtCategory.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Enter all details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be cleared", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                txtBookName.Clear();
                txtAuthorName.Clear();
                txtDescription.Clear();
                txtCategory.Clear();
                txtQuantity.Clear();
            }
        }
    }
}
