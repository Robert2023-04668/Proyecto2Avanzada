using DatabaseFirst.Repositories;
using DatabaseFirst.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Data;

namespace DatabaseFirst.Forms.UI
{
    public partial class frmOrders : Form
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IProductRepository _productRepository;
        private readonly CustomerRepository _customerRepository;
        private readonly IShipper _shipperRepository;
        private CustomerViewModel _customerViewModel;

        // Lista de productos para ComboBox y UnitPrice
        private List<ProductViewModel> _products = new();

        public frmOrders(IOrdersRepository ordersRepository, IProductRepository productRepository, CustomerRepository customerRepository, IShipper shipperRepository)
        {
            InitializeComponent();
            _ordersRepository = ordersRepository;

            _productRepository = productRepository;
            CargarOrdenes();
            CargarProductos(); 
            CargarDetails();
            ConfigurarEventos();
            _customerRepository = customerRepository;
            CargarCustomer();
            _shipperRepository = shipperRepository;
            CargarShippers();
           
        }

        public void CargarOrdenes()
        {
            var Orders = _ordersRepository.GetOrders().Select(p => new OrdersViewModel
            {
                OrderId = p.OrderId,
                OrderDate = p.OrderDate,
                ShipPostalCode = p.ShipPostalCode,
                ShipCountry = p.ShipCountry,
                CustomerId = p.CustomerId,
                Customer = p.Customer != null ? p.Customer.ContactName : "No Customer",
                EmployeeId = p.EmployeeId,
                Employee = p.Employee != null ? p.Employee.FirstName + " " + p.Employee.LastName : " No employee",
                Freight = p.Freight,
                RequiredDate = p.RequiredDate,
                ShippedDate = p.ShippedDate,
                ShipAddress = p.ShipAddress,
                ShipCity = p.Customer.City,
                ShipRegion = p.ShipRegion,
                ShipName = p.ShipName,
                ShipVia = p.ShipVia
            }).ToList();

            bindingSource1.DataSource = Orders;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns["OrderId"].Visible = false;
            dataGridView1.Columns["EmployeeId"].Visible = false;
            dataGridView1.Columns["ShipPostalCode"].Visible = false;
            dataGridView1.Columns["ShipRegion"].Visible = false;
            dataGridView1.Columns["ShipName"].Visible = false;
            dataGridView1.Columns["ShipAddress"].Visible = false;
            dataGridView1.Columns["ShipCity"].Visible = false;
            dataGridView1.Columns["ShipVia"].Visible = false;
            dataGridView1.Columns["CustomerId"].Visible = false;
        }

        public void CargarProductos()
        {
            _products = _productRepository.GetProducts()
               .Select(p => new ProductViewModel
               {
                   ProductId = p.ProductId,
                   Product = p.ProductName,
                   UnitPrice = p.UnitPrice ?? 0,
                   Category = p.Category.CategoryName,
                   Supplier = p.Supplier.CompanyName
               })
               .ToList();
        }

        public void CargarShippers()
        {
            var _shipper = _shipperRepository.GetShipers().Select(s => new ShipperViewModel
            {
                ShipperId = s.ShipperId,
                CompanyName = s.CompanyName,
                Phone = s.Phone,
            }).ToList();
            cmbShipVia.DataSource = _shipper;
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.ValueMember = "ShipperId";
        }

        public void CargarCustomer()
        {
            //BindingSource bindingCustomer = new BindingSource();
            var _customer = _customerRepository.GetCustomers().Select(c => new CustomerViewModel
            {
                CustomerId = c.CustomerId,
                ContactName = c.ContactName,
                City = c.City,
                Country = c.Country,
                PostalCode = c.PostalCode,
                Region = c.Region,
                Address = c.Address,
               
            }).ToList();
            bindingCustomer.DataSource = _customer;
            cmbCustomer.DataSource = bindingCustomer;
            cmbCustomer.DisplayMember = "ContactName";
            cmbCustomer.ValueMember = "CustomerId";

        }

        public void CargarDetails()
        {
            var Details = _ordersRepository.GetDetails().Select(d => new DetailsViewModel
            {
                OrderId = d.OrderId,
                ProductId = d.ProductId,
                UnitPrice = d.UnitPrice,
                Quantity = d.Quantity,
                Discount = d.Discount
            }).ToList();

            // Configura columna ComboBox
            var comboColumn = (DataGridViewComboBoxColumn)dataGridView2.Columns["Product"];
            comboColumn.DataSource = _products;
            comboColumn.DisplayMember = "Product";
            comboColumn.ValueMember = "ProductId";
            comboColumn.DataPropertyName = "ProductId";

            bindingSource2.DataSource = Details;
        }

        private void ConfigurarEventos()
        {
            dataGridView2.EditingControlShowing += DataGridView2_EditingControlShowing;
        }

        private void DataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == dataGridView2.Columns["Product"].Index
                && e.Control is ComboBox cb)
            {
                cb.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                cb.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cb && cb.SelectedValue is int productId)
            {
                var selectedProduct = _products.Find(p => p.ProductId == productId);
                if (selectedProduct == null) return;

                var row = dataGridView2.CurrentRow;
                if (row != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["UnitPrice"].Value = selectedProduct.UnitPrice);
                    row.Cells["ProductCategoryName"].Value = selectedProduct.Category;
                    row.Cells["ProductSupplierCompanyName"].Value = selectedProduct.Supplier;
                }
            }
        }

        private void CalcularTotal(DataGridViewRow row)
        {
            if (row.Cells["Quantity"].Value != null)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal precio = Math.Round(Convert.ToDecimal(row.Cells["UnitPrice"].Value), 2);
                row.Cells["ExtendedPrice"].Value = quantity * precio;
                totalsi();
            }
        }

        private void totalsi()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal precio = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                total += quantity * precio;
            }
            label2.Text = total.ToString("0.00");
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Quantity")
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                CalcularTotal(row);
            }
        }

        private void cmbCustomer_DisplayMemberChanged(object sender, EventArgs e)
        {

            
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bindingCustomer.Current is CustomerViewModel currentCustomer)
            {
                _customerViewModel = new CustomerViewModel
                {
                    ContactName = currentCustomer.ContactName,
                    City = currentCustomer.City,
                    Country = currentCustomer.Country,
                    CustomerId = currentCustomer.CustomerId,
                    PostalCode = currentCustomer.PostalCode,
                    Region = currentCustomer.Region,
                    Address = currentCustomer.Address,
                };

                Llenartxt();
            }
        }

        private void Llenartxt()
        {
            txtCity.Text = _customerViewModel.City ?? "";
            txtAdress.Text = _customerViewModel.Address ?? "";
            txtPostalCode.Text = _customerViewModel.PostalCode ?? "";
            txtRegion.Text = _customerViewModel.Region ?? "";
            txtShipCountry.Text = _customerViewModel.Country ?? "";
        }
        private void algo()
        {
            _customerViewModel.City = txtCity.Text; 
        }
    }

    public class OrdersViewModel
    {
        public int OrderId { get; set; }
        public string? CustomerId { get; set; }
        public string? Customer { get; set; }
        public int? EmployeeId { get; set; }
        public string? Employee { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipRegion { get; set; }
        public string? ShipPostalCode { get; set; }
        public string? ShipCountry { get; set; }
    }

    public class DetailsViewModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    }

    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Product { get; set; } = "";
        public decimal? UnitPrice { get; set; }
        public string? Category { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public string? Supplier { get; set; }
    }

    public class CustomerViewModel()
    {
        public string CustomerId { get; set; } = null!;
        public string? ContactName { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public string? Region { get; set; }

        public string? PostalCode { get; set; }

        public string? Country { get; set; }
    }

    public class ShipperViewModel()
    {
        public int ShipperId { get; set; }

        public string CompanyName { get; set; } = null!;

        public string? Phone { get; set; }
    }
}