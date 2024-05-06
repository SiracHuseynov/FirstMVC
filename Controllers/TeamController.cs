using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
