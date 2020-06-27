using Darbuotojai.Application.Services;
using Darbuotojai.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Darbuotojai.MVC.Controllers
{
    public class DarbuotojaiController : Controller
    {
        private IDarbuotojaiService _darbuotojaiService;
        
        public DarbuotojaiController(IDarbuotojaiService darbuotojaiService)
        {
            _darbuotojaiService = darbuotojaiService;
        }
        // GET
        public IActionResult Index()
        {
            
            DarbuotojaiViewModel model = _darbuotojaiService.GetDarbuotojai();
            
            return View(model);
        }
    }
}