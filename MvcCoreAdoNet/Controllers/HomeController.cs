using Microsoft.AspNetCore.Mvc;
using MvcCoreAdoNet.Models;

namespace MvcCoreAdoNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Vista1()
        {
            return View();
        }
        public IActionResult VistaReturn()
        {
            return View();
        }
        public IActionResult VistaPersona()
        {
         
            return View();
        }
        public IActionResult VistaDosImg()
        {
            return View();
        }
    }
}
