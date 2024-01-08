using Microsoft.AspNetCore.Mvc;

namespace CustomerFlow.Controller
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
