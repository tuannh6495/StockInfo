using Microsoft.AspNetCore.Mvc;

namespace StockInfo.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
