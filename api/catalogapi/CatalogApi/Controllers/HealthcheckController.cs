using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatalogApi.Controllers
{
    [Route("api/[controller]")]
    public class HealthcheckController : Controller
    {
        [HttpGet]
        public List<string> Get()
        {
            string hostname = Dns.GetHostName();
            var ipAddress = Dns.GetHostEntry(hostname).AddressList.FirstOrDefault();
            var ip = string.Empty;
            if (ipAddress != null)
                ip = ipAddress.ToString();

            return new List<string>{ip,hostname};
        }
    }
}