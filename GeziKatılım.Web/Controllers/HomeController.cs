using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeziKatılım.Web.Model;
using Microsoft.AspNetCore.Mvc;

namespace GeziKatılım.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Travel gezi = new Travel();

            gezi.Id = 1;
            gezi.Name = " Çanakkale Gezisi ";

            return View(gezi);
        }
    }
}