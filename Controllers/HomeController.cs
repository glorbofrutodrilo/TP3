using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP3.Models;

namespace TP3.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {  
        Biblioteca.Inicializarbiblioteca();
        Dictionary<int, Disco>biblioteca = new Dictionary<int, Disco>();
        biblioteca = Biblioteca.DevolverDiccionario();
        return View();   
    }
    
}
