using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApi.Models
{
    public class Product
    {
        public string Sku { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ListPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public IEnumerable<ProductAttribute> Attributes { get; set; }
    }
}
