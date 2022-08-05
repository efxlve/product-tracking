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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        DbProductEntities1 db = new DbProductEntities1();

        private void btnList_Click(object sender, EventArgs e)
        {
            var category = db.TblCategories.ToList();
            dgvCategory.DataSource = category;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblCategory category = new TblCategory();
            category.NAME = txtCategoryName.Text;
            db.TblCategories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Category added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryID.Text);
            var category = db.TblCategories.Find(id);
            db.TblCategories.Remove(category);
            db.SaveChanges();
            MessageBox.Show("Category deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryID.Text);
            var category = db.TblCategories.Find(id);
            category.NAME = txtCategoryName.Text;
            db.SaveChanges();
            MessageBox.Show("Category updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
