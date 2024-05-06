using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
