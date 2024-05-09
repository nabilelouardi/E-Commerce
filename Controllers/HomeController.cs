using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{

//oumaima_lem

    public class HomeController : Controller
    {

    

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        /// le code corrige 
        public int sommeWissal(int a, int b)
        {

               
                return a + b;
        }
        public int sommeMahid(int a, int b)
        {
            int s = a + b;
            return s;
 
        public int sommeDounia(int a, int b)
        {
<<<<<<< HEAD
            int a, b, s = 0;
            s = a + b;
            return s;
=======


            {
                
 loubnaelbzioui
           //correction somme   
                int s = a / 1;

              
                int s = a / 0;
main
                return s + b;
               
                
            }
 
>>>>>>> ef6a65f39b1f1ce674e2e8a6f36dfaf9602e8738
        }
    }
}
