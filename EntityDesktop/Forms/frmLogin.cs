using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDesktop;

namespace EntityDesktop_Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DbProductEntities1 dbProductEntities = new DbProductEntities1();
            var query = from x in dbProductEntities.TblAdmins where x.UserName == txtUserName.Text && x.Password == txtPassword.Text select x;
            if (query.Any())
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is wrong!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
