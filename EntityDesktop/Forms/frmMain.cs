using EntityDesktop_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityDesktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbCategory_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.Show();
        }

        private void pbProduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show();
        }

        private void pbStatistics_Click(object sender, EventArgs e)
        {
            frmStatistic frm = new frmStatistic();
            frm.Show();
        }
    }
}
