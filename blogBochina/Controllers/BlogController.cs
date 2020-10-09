using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blogBochina.Controllers
{
    /// <summary>
    /// Класс для работы со страницами блога
    /// </summary>
    public class BlogController : Controller
    {
        /// Метод возращающий страницу блога
        public IActionResult Index()
        {
            return View();
        }
    }
}
