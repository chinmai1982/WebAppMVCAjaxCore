using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCAjaxCore.Models;
using Newtonsoft.Json;

namespace WebAppMVCAjaxCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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

        public JsonResult GetStudentDetails()
        {
            Student studObj = new Student()
            {
                StudentId = 1,
                StudentName = "Chinmai Sutar",
                Age = 38,
                Address = "1402 Round Rock crossing"
            };
           // var json = JsonConvert.SerializeObject(studObj);
            return Json(studObj);
        }

        public IActionResult SaveStudentDetails()
        {
            return View();
        }


        [HttpPost]
        public JsonResult SaveStudentDetails(Student objStudent)
        {
            return Json(objStudent);
           // return View("SaveStudentDetails",objStudent);
        }
    }
}
