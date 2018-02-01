using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Repository;

namespace Restaurant.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(InstanceRepository repository): base(repository)
        {

        }
        public IActionResult Index()
        {
            var model = Repository.HeaderSliderRepository.GetAll();
            
            return View(model.ToList());
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Reservation()
        {
            return View();
        }


        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
