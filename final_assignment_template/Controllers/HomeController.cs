using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using final_assignment_template.Models;

namespace final_assignment_template.Controllers;

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

    public IActionResult GenAi()
    {
        return View();
    }

    public IActionResult sites()
    {
        return View();
    }
    public IActionResult jobs()
    {
        return View();
    }

    public IActionResult contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

