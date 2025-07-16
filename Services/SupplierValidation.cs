using DatabaseFirst.Forms.UI;
using FluentValidation;

namespace DatabaseFirst.Services
{
    public class SupplierValidation : AbstractValidator<SuppliersViewModel>
    {
        public SupplierValidation()
        {
            RuleFor(a => a.Address).NotEmpty().WithMessage("Address can not be empty");
            RuleFor(a => a.Phone).NotEmpty().WithMessage("Phone can not be empty");
            RuleFor(a => a.City).NotEmpty().WithMessage("City can not be empty");
            RuleFor(a => a.CompanyName).NotEmpty().WithMessage("CompanyName can not be empty");
            RuleFor(a => a.ContactName).NotEmpty().WithMessage("Contact can not be empty");
            RuleFor(a => a.ContactTitle).NotEmpty().WithMessage("ContactTitle can not be empty");
            RuleFor(a => a.Fax).NotEmpty().WithMessage("Fax can not be empty");
            RuleFor(a => a.Country).NotEmpty().WithMessage("Country can not be empty");
            RuleFor(a => a.PostalCode).NotEmpty().WithMessage("PostalCode can not be empty");
            RuleFor(a => a.Region).NotEmpty().WithMessage("Region can not be empty");
        }
    }
}