using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatalogApi.Models;
using CatalogApi.Services;
using Microsoft.Extensions.Logging;

namespace CatalogApi.Controllers
{
    [Route("api/[controller]")]
    public class CatalogController : Controller
    {
        private readonly ICatalogService _catalogService;
        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ICatalogService catalogService, ILogger<CatalogController> logger)
        {
            _catalogService = catalogService ?? throw new ArgumentNullException(nameof(catalogService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET api/catalog
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _catalogService.GetCatalogNames();
        }

        // GET api/catalog/name
        [HttpGet("{name}")]
        public Catalog Get(string name)
        {
            return _catalogService.GetCatalog(name);
        }
    }
}
