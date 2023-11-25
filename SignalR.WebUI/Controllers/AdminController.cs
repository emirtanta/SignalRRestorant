using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
