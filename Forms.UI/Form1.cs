using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFirst.Forms.UI
{
    public partial class frmInicio : Form
    {
        private readonly frmCategories _frmcategories;
        private readonly frmOrders _frmorders;
        private readonly frmProducts _frmproducts;
        private readonly frmSuppliers _frmSuppliers;
        public frmInicio(frmCategories frmcategories, frmOrders frmorders, frmProducts frmproducts, frmSuppliers frmSuppliers)
        {
            InitializeComponent();
            _frmcategories = frmcategories;
            _frmorders = frmorders;
            _frmproducts = frmproducts;
            _frmSuppliers = frmSuppliers;
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmcategories.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmproducts.ShowDialog();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmSuppliers.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmorders.ShowDialog(); 
        }
    }
}
