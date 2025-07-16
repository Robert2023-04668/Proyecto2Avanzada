using FluentValidation;

namespace DatabaseFirst.Services
{
    public class ProductValidation : AbstractValidator<ProductViewModel>
    {
        public ProductValidation()
        {
            RuleFor(a => a.QuantityPerUnit).NotEmpty();
            RuleFor(a => a.ReorderLevel).NotEmpty();
            RuleFor(a => a.UnitPrice).NotEmpty();
            RuleFor(a => a.UnitsInStock).NotEmpty();
            RuleFor(a => a.UnitsOnOrder).NotEmpty();
            RuleFor(a => a.Product).NotEmpty();
        }
    }
}