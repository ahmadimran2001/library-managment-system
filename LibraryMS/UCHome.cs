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
    public partial class UCHome : UserControl
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        int bid;
        int row;
        public UCHome()
        {
            InitializeComponent();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            panelDetails.Visible = false;
            cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from add_book";
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            // getting datagrid view
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ColumnHeadersVisible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // id of row number will be saved in bid
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            // getting data of specific book to update/delete
            panelDetails.Visible = true;
            cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from add_book where id = " + bid + "";
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            // row number will be saved in variable to be used later
            row = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            // getting data in text boxes
            txtBook.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDescription.Text = ds.Tables[0].Rows[0][3].ToString();
            txtCategory.Text = ds.Tables[0].Rows[0][4].ToString();
            txtQuantity.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be cleared", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                panelDetails.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from add_book where id = " + row + "";
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (txtBook.Text != string.Empty && txtAuthor.Text != string.Empty && txtDescription.Text != string.Empty && txtCategory.Text != string.Empty && txtQuantity.Text != string.Empty)
                {
                    cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=lib;Integrated Security=True");
                    cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "update add_book set bname='" + txtBook.Text + "',aname='" + txtAuthor.Text + "',bdesc='" + txtDescription.Text + "',category='" + txtCategory.Text + "',quantity='" + txtQuantity.Text + "' where id=" + row + "";
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds);
                }
                else
                {
                    MessageBox.Show("Enter all details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            panelDetails.Visible = true;
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text != string.Empty)
            {
                // if user enters book name
                cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
                cmd = new SqlCommand();
                cmd.Connection = cn;
                // sql query for for hints for book name
                cmd.CommandText = "select * from add_book where bname LIKE '" + txtBookName.Text + "%'";
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                // if search box is empty
                cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select * from add_book";
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
