using EntityDesktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityDesktop_Forms
{
    public partial class frmStatistic : Form
    {
        public frmStatistic()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DbProductEntities1 dbProductEntities = new DbProductEntities1();

        private void frmStatistic_Load(object sender, EventArgs e)
        {
            lbl1.Text = dbProductEntities.TblCategories.Count().ToString();
            lbl2.Text = dbProductEntities.TblProducts.Count().ToString();
            lbl3.Text = dbProductEntities.TblCustomers.Count(x => x.Status == true).ToString();
            lbl4.Text = dbProductEntities.TblCustomers.Count(x => x.Status == false).ToString();
            lbl5.Text = dbProductEntities.TblProducts.Count(x => x.Category == 1).ToString();
            lbl6.Text = dbProductEntities.TblProducts.Sum(x => x.Stock).ToString();
            lbl7.Text = (from x in dbProductEntities.TblProducts orderby x.Price descending select x.ProductName).FirstOrDefault();
            lbl8.Text = (from x in dbProductEntities.TblProducts orderby x.Price ascending select x.ProductName).FirstOrDefault();
            lbl9.Text = (from x in dbProductEntities.TblCustomers select x.City).Distinct().Count().ToString();
            lbl10.Text = dbProductEntities.TblSales.Sum(x => x.Price).ToString() + " $";
            lbl11.Text = dbProductEntities.BringBrand().FirstOrDefault();
            lbl12.Text = dbProductEntities.TblProducts.Count(X => X.ProductName == "Refrigerator").ToString();
        }
    }
}
