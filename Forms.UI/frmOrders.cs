using DatabaseFirst.Repositories.Interfaces;
using System.Data;

namespace DatabaseFirst.Forms.UI
{
    public partial class frmOrders : Form
    {
        private readonly IOrdersRepository _ordersRepository;
        public frmOrders(IOrdersRepository ordersRepository)
        {
            InitializeComponent();
            _ordersRepository = ordersRepository;
            CargarDatos();
        }

        public void CargarDatos()
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
                ShipCity = p.ShipCity,
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
        private void frmOrders_Load(object sender, EventArgs e)
        {

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
}
