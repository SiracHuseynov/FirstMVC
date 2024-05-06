using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
