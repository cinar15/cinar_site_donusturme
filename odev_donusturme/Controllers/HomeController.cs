using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using odev_donusturme.Models;

namespace odev_donusturme.Controllers;

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

    
    public IActionResult Gezi()
    {
        return View();
    }


    public IActionResult Anasayfa()
    {
        return View();
    }

        public IActionResult Kategori()
    {
        return View();
    }

            public IActionResult Hakkimizda()
    {
        return View();
    }


            public IActionResult İletisim()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
