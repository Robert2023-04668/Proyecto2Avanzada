using NLog;

namespace DatabaseFirst.Forms.UI
{
    public partial class frmInicio : Form
    {
        private readonly frmCategories _frmcategories;
        private readonly frmOrders _frmorders;
        private readonly frmProducts _frmproducts;
        private readonly frmSuppliers _frmSuppliers;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public frmInicio(frmCategories frmcategories, frmOrders frmorders, frmProducts frmproducts, frmSuppliers frmSuppliers)
        {
            InitializeComponent();
            _frmcategories = frmcategories;
            _frmorders = frmorders;
            _frmproducts = frmproducts;
            _frmSuppliers = frmSuppliers;
            logger.Info("FrmInicio inicializado correctamente");
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Info("Cargando frmCategory");
                _frmcategories.ShowDialog();
                logger.Info("frmCategory inicializado correctamente");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Erorr al cargar frmCategory");
            }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Info("Cargando frmproducts");
                _frmproducts.ShowDialog();
                logger.Info("frmproducts inicializado correctamente");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Erorr al cargar frmproducts");
            }
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Info("Cargando frmSuppliers");
                _frmSuppliers.ShowDialog();
                logger.Info("frmSuppliers inicializado correctamente");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Erorr al cargar frmSuppliers");
            }
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Info("Cargando frmorders");
                _frmorders.ShowDialog();
                logger.Info("frmorders inicializado correctamente");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Erorr al cargar frmorders");
            }
        }
    }
}