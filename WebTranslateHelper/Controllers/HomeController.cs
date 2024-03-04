using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebTranslateHelper.Models;

namespace WebTranslateHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddSentence()
        {
            return View();
        }
    }
}
