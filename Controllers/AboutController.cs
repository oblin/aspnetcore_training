using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OdeToFood.Controllers
{
    // [Route("company/[controller]")]
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        // GET: /<controller>/
        [RouteAttribute("index")]
        public string Phone()
        {
            return "It's my phone: 777-5677";
        }

        // [RouteAttribute("[action]")]
        public string Country()
        {
            return "Taiwan";
        }
    }
}
