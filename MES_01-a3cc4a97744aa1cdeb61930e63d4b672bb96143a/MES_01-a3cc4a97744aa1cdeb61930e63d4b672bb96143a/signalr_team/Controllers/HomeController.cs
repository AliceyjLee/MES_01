using Microsoft.AspNetCore.Mvc;
using signalr_team.Models;
using System.Diagnostics;

namespace signalr_team.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Img()
        {
            return View();
        }

        // 라즈베리파이 실시간 영상
        public IActionResult Index()
        {
            return Redirect("/home/iotmonitering");
        }


        // 메인 - 로그인 화면
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult signuppage()
        {
            return View();
        }

        // 메인페이지
        public IActionResult IoTMonitering()
        {
            return View();
        }

        public IActionResult InventoryMonitering()
        {
            return View();
        }

        public IActionResult ProdMonitering()
        {
            return View();
        }

        public IActionResult ProductDetailed()
        {
            return View();
        }

        // 재고관리
        public IActionResult InventoryList()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }

        // 생산관리 
        public IActionResult OrderList()
        {
            return View();
        }
        public IActionResult OrderRegister()
        {
            return View();
        }
        public IActionResult IndividualOrderList()
        {
            return View();
        }
        public IActionResult RequestList()
        {
            return View();
        }
        public IActionResult RequestRegister()
        {
            return View();
        }
        public IActionResult Status()
        {
            return View();
        }



        // 사원관리

        public IActionResult Userinfo()
        {
            return View();
        }
        public IActionResult UserAuth()
        {
            return View();
        }

        public IActionResult ProductRegister()
        {
            return View();
        }

        public IActionResult UserList()
        {
            return View();
        }

        public IActionResult Privacy()
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