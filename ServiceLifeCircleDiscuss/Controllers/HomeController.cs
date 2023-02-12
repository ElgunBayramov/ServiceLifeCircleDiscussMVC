using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceLifeCircleDiscuss.AppCode.Services;
using ServiceLifeCircleDiscuss.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLifeCircleDiscuss.Controllers
{
    public class HomeController : Controller
    {
        private readonly CryptoService cryptoService;

        public HomeController(CryptoService cryptoService)
        {
            this.cryptoService = cryptoService;
        }
        public IActionResult Index()
        {
            ViewBag.ServiceInstanceId = cryptoService.InstanceId;
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
