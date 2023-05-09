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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace LibraryMS
{
    public partial class MainScreen : Form
    {
        SqlCommand cmd;
        public MainScreen()
        {
            InitializeComponent();
            customizeDesign();
            panelHighlight.Visible = false;
            UCMain uc = new UCMain();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void customizeDesign()
        {
            panelSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure You want to close the application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            panelHighlight.Visible = true;
            panelHighlight.Height = btnUser.Height;
            panelHighlight.Top = btnUser.Top;
            UCUserDetails uc = new UCUserDetails();
            addUserControl(uc);
        }

        private void panelSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
            panelHighlight.Height = btnUser.Height;
            panelHighlight.Top = btnUser.Top;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelHighlight.Visible = true;
            panelHighlight.Height = btnHome.Height;
            panelHighlight.Top = btnHome.Top;
            UCHome uc = new UCHome();
            addUserControl(uc);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelHighlight.Visible = true;
            panelHighlight.Height = btnAdd.Height;
            panelHighlight.Top = btnAdd.Top;
            UCAddBook uc = new UCAddBook();
            addUserControl(uc);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            panelHighlight.Visible = true;
            panelHighlight.Height = btnBorrow.Height;
            panelHighlight.Top = btnBorrow.Top;
            UCBorrowBook uc = new UCBorrowBook();
            addUserControl(uc);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
           
            
            panelHighlight.Visible = true;
            panelHighlight.Height = btnReturn.Height;
            panelHighlight.Top = btnReturn.Top;
            UCReturnBook uc = new UCReturnBook();
            addUserControl(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            register register = new register();
            register.ShowDialog();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            panelHighlight.Visible = false;
            UCMain uc = new UCMain();
            addUserControl(uc);
        }
    }
}
