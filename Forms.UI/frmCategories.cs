using DatabaseFirst.Repositories.Interfaces;
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
    public partial class frmCategories : Form
    {
        private readonly ICategoryRepository _categoryRepository;
        public frmCategories(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            InitializeComponent();
            CargarDatos();
        }


        public void CargarDatos()
        {
            var categories = _categoryRepository.GetCategories().Select(p => new CategoryViewModel
            {
                CategoryId = p.CategoryId,
                CategoryName = p.CategoryName,
                Description = p.Description,
                Picture = p.Picture,

            }).ToList();

            bindingSource1.DataSource = categories;
            dgvCategory.DataSource = bindingSource1;
            dgvCategory.Columns["CategoryId"].Visible = false;



        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            txtName.DataBindings.Add("Text", bindingSource1, "CategoryName");
            richTextBox1.DataBindings.Add("Text", bindingSource1, "Description");
        }
    }

    public class CategoryViewModel
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        public string? Description { get; set; }

        public byte[]? Picture { get; set; }

    }
}
