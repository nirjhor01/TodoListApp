using Microsoft.AspNetCore.Mvc;

namespace TodoApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
