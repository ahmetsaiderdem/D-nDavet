using DüğünDavet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DüğünDavet.Controllers
{
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
        [HttpGet]
        public ViewResult CevapFormu()
        {

            return View();
        }
        [HttpPost]
        public ViewResult CevapFormu(Cevap cevap)
        {
            if (ModelState.IsValid)
            {
                Repository.CevapEkle(cevap);
                return View("Tesekkurler", cevap);
            }
            else
            {
                return View();
            }
        }
        public ViewResult CevaplarıListele() 
        {
            return View(Repository.cevaplar.Where(x=> x.DuguneGelecekmi==true));

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
    }
}
