using DatabaseFirst.Models;
using DatabaseFirst.Repositories.Interfaces;
using DatabaseFirst.Services;
using FluentValidation.Results;

namespace DatabaseFirst
{
    public partial class frmProducts : Form
    {
        private readonly IProductRepository _IProductRepository;
        private readonly ProductValidation _validationRules;
        private ProductViewModel _tempProductVM = new ProductViewModel();

        public frmProducts(IProductRepository iProductRepository, ProductValidation validationRules)
        {
            _IProductRepository = iProductRepository;
            _validationRules = validationRules;

            InitializeComponent();
            CargarDatos();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // NO DATA BINDINGS a bindingSource1 !!
            // Solo se asignan los valores a mano
        }

        public void CargarDatos()
        {
            var products = _IProductRepository.GetProducts()
                .Select(p => new ProductViewModel
                {
                    ProductId = p.ProductId,
                    Product = p.ProductName,
                    CategoryId = p.CategoryId,
                    SupplierId = p.SupplierId,
                    Category = p.Category != null ? p.Category.CategoryName : "Sin categoría",
                    Supplier = p.Supplier != null ? p.Supplier.CompanyName : "Sin Suplidor",
                    QuantityPerUnit = p.QuantityPerUnit,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    UnitsOnOrder = p.UnitsOnOrder,
                    ReorderLevel = p.ReorderLevel,
                    Discontinued = p.Discontinued
                })
                .ToList();

            bindingSource1.DataSource = products;
            dgvProducts.DataSource = bindingSource1;

            dgvProducts.Columns["ProductId"].Visible = false;
            dgvProducts.Columns["CategoryId"].Visible = false;
            dgvProducts.Columns["SupplierId"].Visible = false;
        }




        private void LimpiarTextbox()
        {
            txtProduct.Text = _tempProductVM.Product ?? "";
            txtCategory.Text = _tempProductVM.Category ?? "";
            txtSupplier.Text = _tempProductVM.Supplier ?? "";
            txtQPU.Text = _tempProductVM.QuantityPerUnit ?? "";
            txtUnitprice.Text = _tempProductVM.UnitPrice?.ToString() ?? "";
            txtUnitInStock.Text = _tempProductVM.UnitsInStock?.ToString() ?? "";
            txtUnitOnOrder.Text = _tempProductVM.UnitsOnOrder?.ToString() ?? "";
            txtReordderLevel.Text = _tempProductVM.ReorderLevel?.ToString() ?? "";
            checkBox1.Checked = _tempProductVM.Discontinued;
        }


        private void CargarViewmodel()
        {
            _tempProductVM.Product = txtProduct.Text;
            _tempProductVM.QuantityPerUnit = txtQPU.Text;
            _tempProductVM.UnitPrice = decimal.TryParse(txtUnitprice.Text, out var up) ? up : null;
            _tempProductVM.UnitsInStock = short.TryParse(txtUnitInStock.Text, out var us) ? us : null;
            _tempProductVM.UnitsOnOrder = short.TryParse(txtUnitOnOrder.Text, out var uo) ? uo : null;
            _tempProductVM.ReorderLevel = short.TryParse(txtReordderLevel.Text, out var rl) ? rl : null;
            _tempProductVM.Discontinued = checkBox1.Checked;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            CargarViewmodel();

            ValidationResult results = _validationRules.Validate(_tempProductVM);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            if (_tempProductVM.ProductId == 0)
            {
                var confirm = MessageBox.Show("¿Seguro que desea CREAR este producto?", "Confirmar", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    var newProduct = new Product
                    {
                        ProductName = _tempProductVM.Product,
                        CategoryId = _tempProductVM.CategoryId,
                        SupplierId = _tempProductVM.SupplierId,
                        QuantityPerUnit = _tempProductVM.QuantityPerUnit,
                        UnitPrice = _tempProductVM.UnitPrice,
                        UnitsInStock = _tempProductVM.UnitsInStock,
                        UnitsOnOrder = _tempProductVM.UnitsOnOrder,
                        ReorderLevel = _tempProductVM.ReorderLevel,
                        Discontinued = _tempProductVM.Discontinued
                    };

                    _IProductRepository.Add(newProduct);
                    MessageBox.Show("Producto creado correctamente");
                }
            }
            else
            {
                var confirm = MessageBox.Show("¿Seguro que desea ACTUALIZAR este producto?", "Confirmar", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    var updatedProduct = new Product
                    {
                        ProductId = _tempProductVM.ProductId,
                        ProductName = _tempProductVM.Product,
                        CategoryId = _tempProductVM.CategoryId,
                        SupplierId = _tempProductVM.SupplierId,
                        QuantityPerUnit = _tempProductVM.QuantityPerUnit,
                        UnitPrice = _tempProductVM.UnitPrice,
                        UnitsInStock = _tempProductVM.UnitsInStock,
                        UnitsOnOrder = _tempProductVM.UnitsOnOrder,
                        ReorderLevel = _tempProductVM.ReorderLevel,
                        Discontinued = _tempProductVM.Discontinued
                    };

                    _IProductRepository.Update(updatedProduct);
                    MessageBox.Show("Producto actualizado correctamente");
                }
            }

            // Refrescar lista después de guardar
            CargarDatos();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (_tempProductVM.ProductId != 0)
            {
                var confirm = MessageBox.Show("¿Seguro que desea eliminar este producto?", "Confirmar", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    _IProductRepository.Delete(_tempProductVM.ProductId);
                    MessageBox.Show("Producto eliminado correctamente");
                    CargarDatos();
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _tempProductVM = new ProductViewModel();
            LimpiarTextbox();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current is ProductViewModel currentProduct)
            {
                _tempProductVM = new ProductViewModel
                {
                    ProductId = currentProduct.ProductId,
                    Product = currentProduct.Product,
                    CategoryId = currentProduct.CategoryId,
                    SupplierId = currentProduct.SupplierId,
                    Category = currentProduct.Category,
                    Supplier = currentProduct.Supplier,
                    QuantityPerUnit = currentProduct.QuantityPerUnit,
                    UnitPrice = currentProduct.UnitPrice,
                    UnitsInStock = currentProduct.UnitsInStock,
                    UnitsOnOrder = currentProduct.UnitsOnOrder,
                    ReorderLevel = currentProduct.ReorderLevel,
                    Discontinued = currentProduct.Discontinued
                };

                LimpiarTextbox();
                
            }
        }
    }

    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Product { get; set; } = "";
        public string? Category { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public string? Supplier { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
