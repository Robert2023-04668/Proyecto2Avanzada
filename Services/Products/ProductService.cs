using DatabaseFirst.Models;
using DatabaseFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Services.Products
{
    public class ProductService
    {
        private readonly IProductRepository _repository;
         
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void Save(ProductViewModel viewModel)
        {
            var product = new Product
            {
                ProductId = viewModel.ProductId,
                ProductName = viewModel.Product,
                CategoryId = viewModel.CategoryId,
                SupplierId = viewModel.SupplierId,
                QuantityPerUnit = viewModel.QuantityPerUnit,
                UnitPrice = viewModel.UnitPrice,
                UnitsInStock = viewModel.UnitsInStock,
                UnitsOnOrder = viewModel.UnitsOnOrder,
                ReorderLevel = viewModel.ReorderLevel,
                Discontinued = viewModel.Discontinued
            };
        }




        public IEnumerable<ProductViewModel> GetAll()
        {
            return _repository.GetProducts().Select(p => new ProductViewModel 
            {
            
            });
        }
    }
}
