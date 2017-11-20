using CatalogApi.Controllers;
using CatalogApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using CatalogApi.Models;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace CatalogApi.Tests.Controllers
{
    public class CatalogControllerUnitTests
    {
        [Fact]
        public void ControllerRequiresParameterizedConstructorWithICatalogServiceAndILogger()
        {

            var mockCatalogService = new Moq.Mock<ICatalogService>().Object;
            var mockLogger = new Mock<ILogger<CatalogController>>().Object;

            var controller = Activator.CreateInstance(typeof(CatalogController), mockCatalogService, mockLogger);

            Assert.NotNull(controller);
        }

        [Fact]
        public void ControllerParameterizedConstructorThrowsArgNullExceptionForNullICatalogService()
        {

            ICatalogService catalogService = null;
            var mockLogger = new Mock<ILogger<CatalogController>>().Object;

            Assert.Throws(typeof(ArgumentNullException), () => new CatalogController(catalogService, mockLogger));

        }

        [Fact]
        public void ControllerParameterizedConstructorThrowsArgNullExceptionForNullILogger()
        {

            var mockCatalogService = new Moq.Mock<ICatalogService>().Object;
            ILogger<CatalogController> logger = null;

            Assert.Throws(typeof(ArgumentNullException), () => new CatalogController(mockCatalogService, logger));

        }

        [Fact]
        public void ControllerGetWithCatalogNameReturnsCatalog()
        {
            
            var catalog = CreateCatalog();
            var catalogName = catalog.Name;

            var mockCatalogService = new Moq.Mock<ICatalogService>();
            mockCatalogService.Setup(m => m.GetCatalog(catalogName)).Returns(catalog);

            var mockLogger = new Mock<ILogger<CatalogController>>().Object;

            var controller = new CatalogController(mockCatalogService.Object, mockLogger);
            var result = controller.Get(catalogName);

            Assert.NotNull(result);
            Assert.Equal(catalog.Name,result.Name);
            Assert.Equal(catalog.Categories.Count(), result.Categories.Count());
        }

        [Fact]
        public void ControllerGetCatalogNamesReturnsCatalogNameList()
        {
            var catalogNames = new List<string> {"Movies", "Books"};
            var mockCatalogService = new Moq.Mock<ICatalogService>();
            mockCatalogService.Setup(m => m.GetCatalogNames()).Returns(catalogNames);

            var mockLogger = new Mock<ILogger<CatalogController>>().Object;

            var controller = new CatalogController(mockCatalogService.Object, mockLogger);
            var result = controller.Get();

            Assert.NotNull(result);
            Assert.Equal(catalogNames.Count(), result.Count());
        }


        private Catalog CreateCatalog()
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
