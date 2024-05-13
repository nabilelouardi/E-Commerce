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

        //la somme
        //..

        /// le code corrige 
        ///  <summary>
        /// le code corrige 
        /// </summary>
        /// <param name="MASBAH EL MAHDI"></param>
        /// <returns></returns>
        /// 
        public int sommeSohaibSoussi(int x, int y)
        {
            return x + y;
        }

        public int sommeLotfiSounny(int x, int y)
        {
            return x + y;
        }

        public int sommeYounes(int x, int y)
        {
            return x + y;
        }
        public int sommeEssayhOumaima(int o , int m)
        {
            return o + m;
        }

        public int sommeWissal(int a, int b)
        {

               
                return a + b;
        }
        public int sommeMahid(int a, int b)
        {
            int s = a + b;
            return s;
        }

        public int sommeoumama(int a, int b)
        {
            int s = a + b;
            return s;
        }



        public int sommeOthmaneBoumya(int a, int b)
        {
            return a + b;
        }

        public int sommeDounia(int a, int b)

        {  

            int s = 0;
            s = a + b;
            return s;


        }
        public int sommeEttaoubbali(int a, int b)
        {
            int s = a + b;
            return s;
        }

        public int sommeHraiche(int a, int b) {
            return a + b;
        }


        public int sommeBelamine(int a, int b)

        {
            return a + b;
        }

        public int sommejasserfnine(int x, int y)
        {
            return x + y;
        }
    }
}
