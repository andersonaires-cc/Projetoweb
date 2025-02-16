﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebProjeto.Models;

namespace WebProjeto.Controllers
{
    public class HomeController : Controller
    {
        
        // Apagar esta linha
        private readonly ILogger<HomeController> _logger;

        // Apagar também este construtor
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
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