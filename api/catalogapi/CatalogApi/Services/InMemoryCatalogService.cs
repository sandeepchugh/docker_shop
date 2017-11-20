using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogApi.Models;

namespace CatalogApi.Services
{
    public class InMemoryCatalogService : ICatalogService
    {
        public IEnumerable<string> GetCatalogNames()
        {
            return new List<string>{"Movies", "Books"};
        }

        public Catalog GetCatalog(string catalogName)
        {
            return new Catalog
            {
                Name = "Movies",
                Categories = new List<ProductCategory> {
                    new ProductCategory{
                        Name = "Action",
                        Products = new List<Product>{
                            new Product {
                                Name = "Terminator",
                                Description = "A machine comes from the future to destroy manikind",
                                ListPrice = 22.00M,
                                SalesPrice = 14.00M,
                                Sku = "MOV0001",
                                Title = "Terminator: Man vs Machine",
                                Attributes = new List<ProductAttribute>{
                                    new ProductAttribute{
                                        Category = "Technical Details",
                                        Name = "Runtime",
                                        Value = "1:22:00"
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
