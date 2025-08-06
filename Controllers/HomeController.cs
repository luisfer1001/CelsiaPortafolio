using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CelsiaPortafolio.Models;

namespace CelsiaPortafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //ViewBag.Nombre = "Luis Salas 2";
        var persona = new Persona()
        {
            Nombre = "Luis Salas",
            Edad = 15
        };
        
        //ViewBag.Edad = "50";
        //return View("Index", "Roberto");
        return View(persona);
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
