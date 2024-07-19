using Microsoft.AspNetCore.Mvc;
using StockInfo.Web.Models;
using System.Diagnostics;

namespace StockInfo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult XaHoi()
        {
            return View();
        }

        public IActionResult ChungKhoan()
        {
            return View();
        }

        public IActionResult BatDongSan()
        {
            return View();
        }

        public IActionResult DoanhNghiep()
        {
            return View();
        }

        public IActionResult NganHang()
        {
            return View();
        }

        public IActionResult TaiChinhQuocTe()
        {
            return View();
        }

        public IActionResult ViMo()
        {
            return View();
        }

        public IActionResult KinhTeSo()
        {
            return View();
        }

        public IActionResult ThiTruong()
        {
            return View();
        }

        public IActionResult Song()
        {
            return View();
        }

        public IActionResult Lifestyle()
        {
            return View();
        }

        public IActionResult DuLieu()
        {
            return View();
        }

        public IActionResult Top200()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
