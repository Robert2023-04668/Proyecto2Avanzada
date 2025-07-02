using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DatabaseFirst.frmProducts;

namespace DatabaseFirst.Services
{
    public class ProductValidation: AbstractValidator<ProductViewModel>
    {
        public ProductValidation() 
        { 
           
            RuleFor(a=> a.QuantityPerUnit).NotEmpty();  
            RuleFor(a=> a.ReorderLevel).NotEmpty();  
            RuleFor(a=> a.UnitPrice).NotEmpty();  
            RuleFor(a=> a.UnitsInStock).NotEmpty();  
            RuleFor(a=> a.UnitsOnOrder).NotEmpty(); 
            RuleFor(a=> a.Product).NotEmpty(); 
        }
    }
}
