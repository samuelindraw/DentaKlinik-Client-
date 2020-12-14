using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CloudDentist.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace CloudDentist.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("Userrole") == "Pasien")
            {

            }
            return View();
        }

        public IActionResult Privacy()
        {
           
            return View();
        }
        public IActionResult UnAuthorized()
        {
            return View();
        }
        public IActionResult ERROR403()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
