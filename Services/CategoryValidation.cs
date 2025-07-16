using DatabaseFirst.Forms.UI;
using FluentValidation;

namespace DatabaseFirst.Services
{
    public class CategoryValidation : AbstractValidator<CategoryViewModel>
    {
        public CategoryValidation()
        {
            RuleFor(a => a.CategoryName).NotEmpty().WithMessage("El Nombre es necesario");
            RuleFor(a => a.Description).NotEmpty().WithMessage("Otorgue una descripccion a la categoria");
        }
    }
}