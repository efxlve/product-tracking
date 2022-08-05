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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        DbProductEntities1 db = new DbProductEntities1();

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = (from x in db.TblProducts select new
            {
                x.ProductID,
                x.ProductName,
                x.Brand,
                x.Stock,
                x.Price,
                x.TblCategory.NAME
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblProduct product = new TblProduct();
            product.ProductName = txtProductName.Text;
            product.Brand = txtBrand.Text;
            product.Stock = Convert.ToInt32(txtStock.Text);
            product.Price = Convert.ToInt32(txtPrice.Text);
            product.Status = true;
            product.Category = int.Parse(cmbCategory.SelectedValue.ToString());
            db.TblProducts.Add(product);
            db.SaveChanges();
            MessageBox.Show("Product added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProductID.Text);
            var product = db.TblProducts.Find(id);
            db.TblProducts.Remove(product);
            db.SaveChanges();
            MessageBox.Show("Product deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProductID.Text);
            var product = db.TblProducts.Find(id);
            product.ProductName = txtProductName.Text;
            product.Brand = txtBrand.Text;
            product.Stock = Convert.ToInt32(txtStock.Text);
            product.Price = Convert.ToInt32(txtPrice.Text);
            product.Status = true;
            product.Category = int.Parse(cmbCategory.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Product updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            var category = (from x in db.TblCategories select new {x.ID, x.NAME}).ToList();
            cmbCategory.ValueMember = "ID";
            cmbCategory.DisplayMember = "NAME";
            cmbCategory.DataSource = category;
        }
    }
}
