using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Services.Products
{
    public class ProductViewModel
    {
   
            public int ProductId { get; set; }
            public string Product { get; set; } = null!;
            public string? Category { get; set; }
            public int? CategoryId { get; set; }
            public int? SupplierId { get; set; }
            public string? Supplier { get; set; }
            public string? QuantityPerUnit { get; set; }
            public decimal? UnitPrice { get; set; }
            public short? UnitsInStock { get; set; }
            public short? UnitsOnOrder { get; set; }
            public short? ReorderLevel { get; set; }
            public bool Discontinued { get; set; }

    }
}
