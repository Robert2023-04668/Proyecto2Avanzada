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
        public frmCategories(ICategoryRepository categoryRepository, CategoryValidation validationRules )
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

        private void frmCategories_Load(object sender, EventArgs e)
        {
            txtName.DataBindings.Add("Text", bindingSource1, "CategoryName");
            txtDescription.DataBindings.Add("Text", bindingSource1, "Description");
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            var categoryVM = new CategoryViewModel
            {
                CategoryName = txtName.Text,
                Description = txtDescription.Text
            };
            var results = _validationRules.Validate(categoryVM);
            if(!results.IsValid)
            { 
                foreach(var failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage,"Validation",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                return;
            }

            else if  (bindingSource1.Current is CategoryViewModel currentCategory)
            {
                if (currentCategory.CategoryId == 0)
                {
                    var result = MessageBox.Show("Esta seguro de agregar esta nueva categoria?", "Agregar ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        Category category = new Category();
                        category.CategoryId = currentCategory.CategoryId;
                        category.CategoryName = currentCategory.CategoryName;
                        category.Description = currentCategory.Description;
                        category.Picture = currentCategory.Picture;

                        _categoryRepository.Add(category);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    var result = MessageBox.Show("Esta seguro de Actualizar esta nueva categoria?", "Agregar ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        Category category = new Category();
                        category.CategoryId = currentCategory.CategoryId;
                        category.CategoryName = currentCategory.CategoryName;
                        category.Description = currentCategory.Description;
                        category.Picture = currentCategory.Picture;

                        _categoryRepository.Update(category);
                    }
                    else
                    {
                        return;
                    }
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
