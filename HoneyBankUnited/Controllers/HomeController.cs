using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HoneyBankUnited.Models;

namespace HoneyBankUnited.Controllers
{
    public class HomeController : Controller
    {
        private readonly Good_HoneyBankUnitedDBContext _dbContext;

        public HomeController(Good_HoneyBankUnitedDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult UserPage()
        {
            return View(_dbContext.Account);
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult SavingsPage()
        {
            return View();
        }
        public IActionResult CheckingPage()
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
