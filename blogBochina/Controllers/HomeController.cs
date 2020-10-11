using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using blogBochina.Model;
using blogBochina.Domain.Model;

namespace blogBochina.Controllers
{
    /// <summary>
    ///  Контроллер работающий с домашней страницей и страницей регестрации
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        /// Конструктор контроллера 
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /// Метод возвращающий домашнюю страницу
        public IActionResult Index()
        {
            return View();
        }
        /// Метод возвращающий страницу регестрации
        public IActionResult Privacy()
        {
            return View();
        }
        /// Возврат ошибки
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
