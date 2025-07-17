using DatabaseFirst.Models;
using DatabaseFirst.Repositories;
using DatabaseFirst.Repositories.Interfaces;
using DatabaseFirst.Services;
using NLog;
using System.Data;

namespace DatabaseFirst.Forms.UI
{
    public partial class frmOrders : Form
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IProductRepository _productRepository;
        private readonly CustomerRepository _customerRepository;
        private readonly IShipper _shipperRepository;
        private readonly IEmployee _EmployeeRepository;
        private CustomerViewModel _customerViewModel;
        private OrdersViewModel _ordersViewModel;
        private DetailsViewModel _detailViewModel;
        private OrderValidation _ordersvalidation;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private List<ProductViewModel> _products = new();



        public frmOrders(IOrdersRepository ordersRepository, IProductRepository productRepository, CustomerRepository customerRepository, IShipper shipperRepository, IEmployee EmployeeRepository, OrderValidation ordersvalidation)
        {
            InitializeComponent();
            _ordersRepository = ordersRepository;
            _EmployeeRepository = EmployeeRepository;
            _productRepository = productRepository;
            CargarOrdenes();
            CargarProducts();
            CargarDetails();
            ConfigurarEventos();
            _customerRepository = customerRepository;
            CargarCustomer();
            _shipperRepository = shipperRepository;
            CargarShippers();
            _ordersvalidation = ordersvalidation;
            CargarEmployees();
            logger.Info("Formulario frmOrders cargado.");
        }

        public void CargarOrdenes()
        {
            try
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
                dataGridView1.Columns["EmployeeId"].Visible = false;
                dataGridView1.Columns["ShipPostalCode"].Visible = false;
                dataGridView1.Columns["ShipRegion"].Visible = false;
                dataGridView1.Columns["ShipName"].Visible = false;
                dataGridView1.Columns["ShipAddress"].Visible = false;
                dataGridView1.Columns["ShipCity"].Visible = false;
                dataGridView1.Columns["ShipVia"].Visible = false;
                dataGridView1.Columns["CustomerId"].Visible = false;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar ordenes");
            }
        }

        public void CargarEmployees()
        {
            try
            {
                var _Employee = _EmployeeRepository.GetEmployees().Select(e => new EmployeeViewModel
                {
                    EmployeeId = e.EmployeeId,
                    FullName = e.FirstName + " " + e.LastName,
                }).ToList();
                cmbEmployee.DataSource = _Employee;
                cmbEmployee.DisplayMember = "FullName";
                cmbEmployee.ValueMember = "EmployeeId";
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Employees");
            }
        }

        public void CargarProducts()
        {
            try
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
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Products");
            }
        }

        public void CargarShippers()
        {
            try
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
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar Shippers");
            }
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

            bindingOrderDetails.DataSource = Details;
            dataGridView3.DataSource = bindingOrderDetails;
        }

        private void CargarOrderViewModel()
        {
            if (_ordersViewModel == null) _ordersViewModel = new OrdersViewModel();
            if (_detailViewModel == null) _detailViewModel = new DetailsViewModel();

            _ordersViewModel.ShipVia = (int?)cmbShipVia.SelectedValue;
            _ordersViewModel.ShipName = txtShipName.Text;
            _ordersViewModel.CustomerId = cmbCustomer.SelectedValue.ToString();
            _ordersViewModel.EmployeeId = (int?)cmbEmployee.SelectedValue;
            _ordersViewModel.ShipAddress = txtAdress.Text;
            _ordersViewModel.Freight = decimal.Parse(txtFreight.Text);
            _ordersViewModel.ShipCity = txtCity.Text;
            _ordersViewModel.ShipRegion = txtRegion.Text;
            _ordersViewModel.OrderDate = dateTimePicker3.Value;
            _ordersViewModel.RequiredDate = dateTimePicker1.Value;
            _ordersViewModel.ShippedDate = dateTimePicker2.Value;
            _ordersViewModel.ShipPostalCode = txtPostalCode.Text;
            _ordersViewModel.ShipCountry = txtShipCountry.Text;
            _detailViewModel.OrderId = _ordersViewModel.OrderId;
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
                decimal discount = Convert.ToDecimal(row.Cells["Discount"].Value);
                decimal discount2 = 0;
                if (discount > 1)
                {
                    MessageBox.Show("El descuento no puede ser mayor al 100%");
                    return;
                }
                if (discount != null)
                {
                    discount2 += (quantity * precio) * discount;
                    row.Cells["ExtendedPrice"].Value = (quantity * precio) - discount2;
                }
                else
                {
                    row.Cells["ExtendedPrice"].Value = quantity * precio;
                }
                totalsi();
            }
        }

        private void totalsi()
        {
            decimal total = 0;
            decimal freigh = 0;

            if (!decimal.TryParse(txtFreight.Text, out freigh))
            {
                freigh = 0;
            }
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal precio = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                decimal discount = Convert.ToDecimal(row.Cells["Discount"].Value);
                decimal discount2 = 0;

                if (discount > 1)
                {
                    MessageBox.Show("El descuento no puede ser mayor al 100%");
                    return;
                }
                else if (discount != null)
                {
                    discount2 += (quantity * precio) * discount;
                    total += (quantity * precio) - discount2;
                }
                else
                {
                    total += quantity * precio;
                }
            }
            label2.Text = total.ToString("0.00");
            if (freigh > 0)
            {
                total = total + (freigh * 2);
                labelTotal.Text = total.ToString("0.00");
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Quantity")
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                CalcularTotal(row);
            }
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

        private void GuardarFacturaConDetalles()
        {
            try
            {
                logger.Info("Iniciando el proceso de guardado de factura con detalles.");

                // 1. Convertir el ViewModel en entidad
                var order = new Order
                {
                    CustomerId = _ordersViewModel.CustomerId,
                    EmployeeId = _ordersViewModel.EmployeeId,
                    OrderDate = _ordersViewModel.OrderDate,
                    RequiredDate = _ordersViewModel.RequiredDate,
                    ShippedDate = _ordersViewModel.ShippedDate,
                    ShipVia = _ordersViewModel.ShipVia,
                    Freight = _ordersViewModel.Freight,
                    ShipName = _ordersViewModel.ShipName,
                    ShipAddress = _ordersViewModel.ShipAddress,
                    ShipCity = _ordersViewModel.ShipCity,
                    ShipRegion = _ordersViewModel.ShipRegion,
                    ShipPostalCode = _ordersViewModel.ShipPostalCode,
                    ShipCountry = _ordersViewModel.ShipCountry
                   
                };

                var results = _ordersvalidation.Validate(_ordersViewModel);
                if (!results.IsValid)
                {
                    foreach (var failure in results.Errors)
                    {
                        logger.Warn("Error de validación: {0}", failure.ErrorMessage);
                        MessageBox.Show(failure.ErrorMessage, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                // 2. Agregar la orden al contexto
                _ordersRepository.Add(order);
                _ordersRepository.Save();
                logger.Info("Orden guardada con ID: {0}", order.OrderId);

                // 3. Recorrer DataGridView2 y construir los detalles
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["Product"].Value == null ||
                        row.Cells["Quantity"].Value == null ||
                        row.Cells["UnitPrice"].Value == null)
                    {
                        logger.Warn("Fila {0} está incompleta. Cancelando operación.", row.Index + 1);
                        MessageBox.Show($"Fila {row.Index + 1} incompleta.");
                        return;
                    }

                    var detail = new OrderDetail
                    {
                        OrderId = order.OrderId,
                        ProductId = Convert.ToInt32(row.Cells["Product"].Value),
                        Quantity = Convert.ToInt16(row.Cells["Quantity"].Value),
                        UnitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value),
                        Discount = float.Parse((string)row.Cells[ "Discount"].Value),
                    };

                    logger.Info("Agregando detalle: ProductoId={0}, Cantidad={1}, Precio={2}",
                        detail.ProductId, detail.Quantity, detail.UnitPrice);

                    _ordersRepository.AddDetail(detail);
                }

                // 4. Guardar todos los detalles
                _ordersRepository.Save();

                logger.Info("Factura y detalles guardados correctamente. OrderID: {0}", order.OrderId);
                MessageBox.Show(order.OrderId.ToString());
                MessageBox.Show("Factura y detalles guardados correctamente.");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al guardar la factura con detalles.");
                MessageBox.Show("Error al guardar: " + ex.Message);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Info("Usuario hizo clic en btnGuardar.");
                CargarOrderViewModel();
                GuardarFacturaConDetalles();
                CargarOrdenes();
                CargarDetails();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al guardar la orden.");
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Quantity")
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                CalcularTotal(row);
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Discount")
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                CalcularTotal(row);
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "UnitPrice")
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                CalcularTotal(row);
            }

        }

        private void txtFreight_TextChanged(object sender, EventArgs e)
        {
            totalsi();

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

    public class EmployeeViewModel()
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; } = null!;
    }
}