using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

/// <summary>
/// Home controller with simplified routing.
/// Privacy page removed and Index redirects to Movies for streamlined navigation.
/// Only Error handling is maintained for proper error management.
/// </summary>
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        // Redirect to Movies page as it's our main functionality
        return RedirectToAction("Index", "Movies");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
