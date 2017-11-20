using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogApi.Models;

namespace CatalogApi.Services
{
    public interface ICatalogService
    {
        Catalog GetCatalog(string catalogName);
        IEnumerable<string> GetCatalogNames();
    }
}
