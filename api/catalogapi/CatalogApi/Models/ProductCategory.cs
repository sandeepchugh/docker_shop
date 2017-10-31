using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApi.Models
{
    public class ProductCategory
    {
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
