using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApi.Models
{
    public class Catalog
    {
        public string Name { get; set; }
        public IEnumerable<ProductCategory> Categories { get; set; }
    }
}
