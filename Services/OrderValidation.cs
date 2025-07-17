using DatabaseFirst.Forms.UI;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Services
{
    public class OrderValidation: AbstractValidator<OrdersViewModel>
    {
        public OrderValidation() 
        {
            RuleFor(c=>c.CustomerId).NotEmpty().WithMessage("No se ha podido identificar el id del usuario");    
            RuleFor(c=>c.EmployeeId).NotEmpty().WithMessage("No se ha podido identificar el empleado");    
            RuleFor(c=>c.ShipVia).NotEmpty().WithMessage("No se ha podido identificar la via del shipping");    
            RuleFor(c=>c.OrderDate).NotEmpty().WithMessage("No se ha podido identificar la fecha que se realizo la orden");    
            RuleFor(c=>c.ShipCity).NotEmpty().WithMessage("No se ha podido identificar a que ciudad sera hara shipping");    
            RuleFor(c=>c.ShipCountry).NotEmpty().WithMessage("No se ha podido identificar a que pais sera el shipping");    
        }
    }
    public class DetailsValidation : AbstractValidator<DetailsViewModel>
    {
        public DetailsValidation()
        {
            RuleFor(details => details.Quantity).NotEmpty().WithMessage("La cantidad de productos seleccionada sdebe ser mayor a 0");
          RuleFor(details => details.ProductId).NotEmpty().WithMessage("No se ha podido identificar el producto");
            RuleFor(details => details.OrderId).NotEmpty().WithMessage("No se ha podido identificar la La orden a la cual se el asignaran los detalles");
         
        }
    }
}
