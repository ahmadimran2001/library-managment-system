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
    public partial class UCReturnBook : UserControl
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter da;
        DataSet ds;
        public UCReturnBook()
        {
            InitializeComponent();
        }

        private void btnSearchRollNo_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-L1BR7L9\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cn.Open();
            cmd = new SqlCommand("select * from bReturn where rollno = '"+txtRollNo.Text+"'", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or no book borrowed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void UCReturnBook_Load(object sender, EventArgs e)
        {
            panelData.Visible = false;
            txtRollNo.Clear();
        }

        String bookName;
        int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panelData.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                row = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bookName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            txtBookName.Text = bookName;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Return Successful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            UCReturnBook_Load(this, null);
        }

        private void txtRollNo_TextChanged(object sender, EventArgs e)
        {
            if (txtRollNo.Text != string.Empty)
            {
                panelData.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtRollNo.Clear();
            dataGridView1.DataSource = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                panelData.Visible = false;
            }
        }
    }
}
