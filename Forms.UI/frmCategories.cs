using DatabaseFirst.Models;
using DatabaseFirst.Repositories.Interfaces;
using DatabaseFirst.Services;
using System.Data;

namespace DatabaseFirst.Forms.UI
{
    public partial class frmCategories : Form
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly CategoryValidation _validationRules;
        private CategoryViewModel _categoryViewModel = new CategoryViewModel();

        public frmCategories(ICategoryRepository categoryRepository, CategoryValidation validationRules)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            _validationRules = validationRules;
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

        private void LimpiarTextbox()
        {
            txtDescription.Text = _categoryViewModel.Description ?? "";
            txtName.Text = _categoryViewModel.CategoryName ?? "";
        }

        private void CargarViewModel()
        {
            _categoryViewModel.Description = txtDescription.Text;
            _categoryViewModel.CategoryName = txtName.Text;
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            CargarViewModel();

            var results = _validationRules.Validate(_categoryViewModel);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            if (_categoryViewModel.CategoryId == 0)
            {
                var result = MessageBox.Show("Esta seguro de agregar esta nueva categoria?", "Agregar ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    var newCategory = new Category
                    {
                        CategoryId = _categoryViewModel.CategoryId,
                        CategoryName = _categoryViewModel.CategoryName,
                        Description = _categoryViewModel.Description,
                        Picture = _categoryViewModel.Picture,
                    };
                    _categoryRepository.Add(newCategory);
                }
            }
            else
            {
                var result = MessageBox.Show("Esta seguro de Actualizar esta nueva categoria?", "Agregar ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    var newCategory = new Category
                    {
                        CategoryId = _categoryViewModel.CategoryId,
                        CategoryName = _categoryViewModel.CategoryName,
                        Description = _categoryViewModel.Description,
                        Picture = _categoryViewModel.Picture,
                    };
                    _categoryRepository.Update(newCategory);
                }
            }
            CargarDatos();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _categoryViewModel = new CategoryViewModel();
            LimpiarTextbox();
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current is CategoryViewModel currenteCategory)
            {
                _categoryViewModel = new CategoryViewModel
                {
                    CategoryId = currenteCategory.CategoryId,
                    CategoryName = currenteCategory.CategoryName,
                    Description = currenteCategory.Description,
                    Picture = currenteCategory.Picture,
                };

                LimpiarTextbox();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
         if(_categoryViewModel.CategoryId != 0)
            {
              var dialog =  MessageBox.Show("Esta seguro  de quere eliminar esta categoria?","Borrado",MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    _categoryRepository.Delete(_categoryViewModel.CategoryId);
                    MessageBox.Show("Producto eliminado satisfactoriamente");
                    CargarDatos();
                }
            }
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