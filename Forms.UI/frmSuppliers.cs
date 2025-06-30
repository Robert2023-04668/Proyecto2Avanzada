using DatabaseFirst.Repositories.Interfaces;

namespace DatabaseFirst.Forms.UI
{
    public partial class frmSuppliers : Form
    {
        private readonly ISupplierRepository _supplierRepository;
        public frmSuppliers(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
            InitializeComponent();
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

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            txtCName.DataBindings.Add("Text", bindingSource1, "CompanyName");
            txtAddres.DataBindings.Add("Text", bindingSource1, "Address");
            txtCity.DataBindings.Add("Text", bindingSource1, "City");
            txtContact.DataBindings.Add("Text", bindingSource1, "ContactName");
            txtCountry.DataBindings.Add("Text", bindingSource1, "Country");
            txtCTitle.DataBindings.Add("Text", bindingSource1, "ContactTitle");
            txtFax.DataBindings.Add("Text", bindingSource1, "Fax");
            txtHomePage.DataBindings.Add("Text", bindingSource1, "HomePage");
            txtPhone.DataBindings.Add("Text", bindingSource1, "Phone");
            txtPostalCode.DataBindings.Add("Text", bindingSource1, "PostalCode");
            txtRegion.DataBindings.Add("Text", bindingSource1, "Region");
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
