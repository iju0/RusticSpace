using BusinessLogicLayer.Store;
using Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class StoreController : Controller
{
    private readonly IStoreService _storeService;
    
    public StoreController(IStoreService storeService)
    {
        _storeService = storeService;
    }

    // GET
    public IActionResult Index()
    {
        StoreViewModel viewModel = new StoreViewModel();
        viewModel.Stores = _storeService.ReadAll();

        return View(viewModel);
    }
}