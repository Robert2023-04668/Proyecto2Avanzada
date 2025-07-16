using DatabaseFirst.Models;
using DatabaseFirst.Repositories.Interfaces;
using DatabaseFirst.Services;

namespace DatabaseFirst.Forms.UI
{
    public partial class frmSuppliers : Form
    {
        private readonly ISupplierRepository _supplierRepository;
        private SuppliersViewModel _supplierViewModel;
        private readonly SupplierValidation _validationRules;

        public frmSuppliers(ISupplierRepository supplierRepository, SupplierValidation validationRules)
        {
            InitializeComponent();
            _supplierRepository = supplierRepository;
            _validationRules = validationRules;

            CargarDtos();
        }

        public void CargarDtos()
        {
            var suppliers = _supplierRepository.GetSuppliers().Select(p => new SuppliersViewModel
            {
                Phone = p.Phone,
                SupplierId = p.SupplierId,
                City = p.City,
                CompanyName = p.CompanyName,
                ContactName = p.ContactName,
                ContactTitle = p.ContactTitle,
                Address = p.Address,
                Region = p.Region,
                PostalCode = p.PostalCode,
                Country = p.Country,
                Fax = p.Fax,
                HomePage = p.HomePage
            }).ToList();

            bindingSource1.DataSource = suppliers;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns["SupplierId"].Visible = false;
            dataGridView1.Columns["Fax"].Visible = false;
            dataGridView1.Columns["Region"].Visible = false;
            dataGridView1.Columns["HomePage"].Visible = false;
            dataGridView1.Columns["PostalCode"].Visible = false;
        }

        private void CargarViewmodel()
        {
            _supplierViewModel.ContactTitle = txtCTitle.Text;
            _supplierViewModel.City = txtCity.Text;
            _supplierViewModel.CompanyName = txtCName.Text;
            _supplierViewModel.ContactName = txtContact.Text;
            _supplierViewModel.Country = txtCountry.Text;
            _supplierViewModel.Address = txtAddres.Text;
            _supplierViewModel.Fax = txtAddres.Text;
            _supplierViewModel.Phone = txtPhone.Text;
            _supplierViewModel.PostalCode = txtPostalCode.Text;
            _supplierViewModel.HomePage = txtHomePage.Text;
            _supplierViewModel.Region = txtRegion.Text;
        }

        private void CargarTxt()
        {
            txtAddres.Text = _supplierViewModel.Address ?? "";
            txtCity.Text = _supplierViewModel.City ?? "";
            txtCName.Text = _supplierViewModel.CompanyName ?? "";
            txtContact.Text = _supplierViewModel.ContactName ?? "";
            txtCountry.Text = _supplierViewModel.Country ?? "";
            txtCTitle.Text = _supplierViewModel.ContactTitle ?? "";
            txtFax.Text = _supplierViewModel.Fax ?? "";
            txtHomePage.Text = _supplierViewModel.HomePage ?? "";
            txtPhone.Text = _supplierViewModel.Phone ?? "";
            txtPostalCode.Text = _supplierViewModel.PostalCode ?? "";
            txtRegion.Text = _supplierViewModel.Region ?? "";
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            CargarViewmodel();

            if (_supplierViewModel.SupplierId == 0)
            {
                var result = MessageBox.Show("Esta seguro de querer agregar este suplidor", "Agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierId = _supplierViewModel.SupplierId;
                    supplier.Address = _supplierViewModel.Address;
                    supplier.City = _supplierViewModel.City;
                    supplier.Region = _supplierViewModel.Region;
                    supplier.CompanyName = _supplierViewModel.CompanyName;
                    supplier.Country = _supplierViewModel.Country;
                    supplier.Phone = _supplierViewModel.Phone;
                    supplier.Fax = _supplierViewModel.Fax;
                    supplier.ContactName = _supplierViewModel.ContactName;
                    supplier.ContactTitle = _supplierViewModel.ContactTitle;
                    supplier.HomePage = _supplierViewModel.HomePage;
                    supplier.PostalCode = _supplierViewModel.PostalCode;

                    _supplierRepository.Add(supplier);
                }
                else
                {
                    return;
                }
            }
            else if (_supplierViewModel.SupplierId != 0)
            {
                var result = MessageBox.Show("Esta seguro de querer Actualizar este suplidor", "Agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierId = _supplierViewModel.SupplierId;
                    supplier.Address = _supplierViewModel.Address;
                    supplier.City = _supplierViewModel.City;
                    supplier.Region = _supplierViewModel.Region;
                    supplier.CompanyName = _supplierViewModel.CompanyName;
                    supplier.Country = _supplierViewModel.Country;
                    supplier.Phone = _supplierViewModel.Phone;
                    supplier.Fax = _supplierViewModel.Fax;
                    supplier.ContactName = _supplierViewModel.ContactName;
                    supplier.ContactTitle = _supplierViewModel.ContactTitle;
                    supplier.HomePage = _supplierViewModel.HomePage;
                    supplier.PostalCode = _supplierViewModel.PostalCode;

                    _supplierRepository.Update(supplier);
                }
                else
                {
                    return;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current is SuppliersViewModel currentSupplier)
            {
                _supplierViewModel = new SuppliersViewModel
                {
                    SupplierId = currentSupplier.SupplierId,
                    Address = currentSupplier.Address,
                    City = currentSupplier.City,
                    Region = currentSupplier.Region,
                    CompanyName = currentSupplier.CompanyName,
                    Country = currentSupplier.Country,
                    Phone = currentSupplier.Phone,
                    Fax = currentSupplier.Fax,
                    ContactName = currentSupplier.ContactName,
                    ContactTitle = currentSupplier.ContactTitle,
                    HomePage = currentSupplier.HomePage,
                    PostalCode = currentSupplier.PostalCode
                };
                CargarTxt();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _supplierViewModel = new SuppliersViewModel();

            CargarTxt();
        }
    }

    public class SuppliersViewModel
    {
        public int SupplierId { get; set; }

        public string CompanyName { get; set; } = null!;

        public string? ContactName { get; set; }

        public string? ContactTitle { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? Region { get; set; }

        public string? PostalCode { get; set; }

        public string? Country { get; set; }

        public string? Phone { get; set; }

        public string? Fax { get; set; }

        public string? HomePage { get; set; }
    }
}