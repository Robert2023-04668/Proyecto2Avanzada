using DatabaseFirst.Models;
using DatabaseFirst.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFirst
{
    public partial class frmProducts : Form
    {
        private readonly IProductRepository _IProductRepository;

        public frmProducts(IProductRepository iProductRepository)
        {
            _IProductRepository = iProductRepository;
            InitializeComponent();
         

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            CargarDatos();
            txtProduct.DataBindings.Add("Text", bindingSource1, "Product");
            txtCategory.DataBindings.Add("Text", bindingSource1, "Category");
            txtSupplier.DataBindings.Add("Text", bindingSource1, "Supplier");
            txtQPU.DataBindings.Add("Text", bindingSource1, "QuantityPerUnit");
            txtUnitprice.DataBindings.Add("Text", bindingSource1, "UnitPrice");
            txtUnitInStock.DataBindings.Add("Text", bindingSource1, "UnitsInStock");
            txtUnitOnOrder.DataBindings.Add("Text", bindingSource1, "UnitsOnOrder");
            txtReordderLevel.DataBindings.Add("Text", bindingSource1, "ReorderLevel");
            checkBox1.DataBindings.Add("Checked", bindingSource1, "Discontinued");
        }



        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {

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

        private void OkBtn_Click(object sender, EventArgs e)
        {


            if (bindingSource1.Current is ProductViewModel currentProduct)
            {

                if (currentProduct.ProductId == 0)
                {
                    MessageBox.Show("Seguro de que quiere Crear este producto?", "Actulizar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    var result = DialogResult;

                    if (result == DialogResult.OK)
                    {

                        var product = new Product
                        {
                            ProductId = currentProduct.ProductId,               // Clave primaria para buscarlo
                            ProductName = currentProduct.Product,               // Nombre
                            CategoryId = currentProduct.CategoryId,
                            SupplierId = currentProduct.SupplierId,
                            QuantityPerUnit = currentProduct.QuantityPerUnit,   // Cantidad por unidad
                            UnitPrice = currentProduct.UnitPrice,               // Precio unitario
                            UnitsInStock = currentProduct.UnitsInStock,         // Unidades en stock
                            UnitsOnOrder = currentProduct.UnitsOnOrder,         // Unidades en orden
                            ReorderLevel = currentProduct.ReorderLevel,         // Nivel de reorden
                            Discontinued = currentProduct.Discontinued
                        };
                        _IProductRepository.Add(product);
                        CargarDatos();
                        MessageBox.Show("Producto registrado Correctamente");
                    }
                    else if (result == DialogResult.Cancel)
                    {

                        return;

                    }
                }
                else
                {
                    MessageBox.Show("Seguro de que quiere actualizar este producto?", "Actulizar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    var result = DialogResult;

                    if (result == DialogResult.OK)
                    {

                        var product = new Product
                        {
                            ProductId = currentProduct.ProductId,               // Clave primaria para buscarlo
                            ProductName = currentProduct.Product,               // Nombre
                            CategoryId = currentProduct.CategoryId,
                            SupplierId = currentProduct.SupplierId,
                            QuantityPerUnit = currentProduct.QuantityPerUnit,   // Cantidad por unidad
                            UnitPrice = currentProduct.UnitPrice,               // Precio unitario
                            UnitsInStock = currentProduct.UnitsInStock,         // Unidades en stock
                            UnitsOnOrder = currentProduct.UnitsOnOrder,         // Unidades en orden
                            ReorderLevel = currentProduct.ReorderLevel,         // Nivel de reorden
                            Discontinued = currentProduct.Discontinued
                        };
                        _IProductRepository.Update(product);
                        CargarDatos();
                        MessageBox.Show("Producto registrado Correctamente");
                    }
                    else if (result == DialogResult.Cancel)
                    {

                        return;

                    }
                }


            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is ProductViewModel currentProduct)
            {
                var product = new Product
                {
                    ProductId = currentProduct.ProductId,
                    ProductName = currentProduct.Product,               // Nombre
                    CategoryId = currentProduct.CategoryId,
                    SupplierId = currentProduct.SupplierId,
                    QuantityPerUnit = currentProduct.QuantityPerUnit,   // Cantidad por unidad
                    UnitPrice = currentProduct.UnitPrice,               // Precio unitario
                    UnitsInStock = currentProduct.UnitsInStock,         // Unidades en stock
                    UnitsOnOrder = currentProduct.UnitsOnOrder,         // Unidades en orden
                    ReorderLevel = currentProduct.ReorderLevel,         // Nivel de reorden
                    Discontinued = currentProduct.Discontinued
                };
                _IProductRepository.Delete(product);
                CargarDatos();
                MessageBox.Show("Producto registrado Correctamente");

            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            bindingSource1.Add(new ProductViewModel());
            bindingSource1.MoveLast();

            txtProduct.Text = "";
            txtCategory.Text = "";
            txtSupplier.Text = "";
            txtQPU.Text = "";
            txtUnitprice.Text = "";
            txtUnitInStock.Text = "";
            txtUnitOnOrder.Text = "";
            txtReordderLevel.Text = "";
            checkBox1.Checked = false;

           
            
        }
    }

    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Product { get; set; } = null!;
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
