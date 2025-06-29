using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Repositories
{
    public interface IProductRepository
    {
        Product GetById(int id);
        IEnumerable<Product> GetProducts();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        public class ProductsRepository : IProductRepository
        {
            private readonly NorthwindContext _context;

            public ProductsRepository(NorthwindContext context)
            {
                _context = context;
            }
            public Product GetById(int productId) => _context.Products.Find(productId);

            public IEnumerable<Product> GetProducts()
            {
                return _context.Products
                 .Include(p => p.Category).Include(p => p.Supplier).AsNoTracking().ToList();
            }

            public void Add(Product product)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }

            public void Update(Product product)
            {
                var existing = _context.Products.Find(product.ProductId);

                if (existing != null)
                {
                    existing.ProductName = product.ProductName;
                    existing.QuantityPerUnit = product.QuantityPerUnit;
                    existing.UnitPrice = product.UnitPrice;
                    existing.UnitsInStock = product.UnitsInStock;
                    existing.UnitsOnOrder = product.UnitsOnOrder;
                    existing.ReorderLevel = product.ReorderLevel;
                    existing.Discontinued = product.Discontinued;

                    _context.SaveChanges();
                }
            }
            public void Delete(Product product)
            {
                var existing = _context.Products.Find(product.ProductId);

                if (existing != null)
                {
                   
                    existing.Discontinued = product.Discontinued = true;
                    _context.SaveChanges();
                }
            }
           
        }
    }
}
