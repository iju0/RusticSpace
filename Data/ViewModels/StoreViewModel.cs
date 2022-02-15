using Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Data.ViewModels;

public class StoreViewModel : PageModel
{
    public IList<Store> Stores { get; set; } 
}