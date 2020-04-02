using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    //[Route("[Controller]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Plus(int? id)
        {
            ViewData["plus"] = id + 10;
            return View();
        }
        
        public IActionResult Multiply(int? id)
        {
            ViewData["multiply"] = id * 10;
            return View();
        }
        
        public IActionResult Minus(int? num1, int? num2)
        {
            ViewData["minus"] = num2 - num1;
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactPost(Contact model)
        {
            ViewData["Name"] = model.Name;
            ViewData["Email"] = model.Email;
            ViewData["Subject"] = model.Subject;
            ViewData["Message"] = model.Message;
            return View();
            //return Redirect("index");
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
