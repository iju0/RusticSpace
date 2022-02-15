using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class StoreController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}