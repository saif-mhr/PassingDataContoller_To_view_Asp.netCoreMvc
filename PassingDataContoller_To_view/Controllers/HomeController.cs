using Microsoft.AspNetCore.Mvc;
using PassingDataContoller_To_view.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingDataContoller_To_view.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["var1"] = "data come from view";
            ViewData["var2"] = DateTime.Now.ToLongDateString();
            string[] arry = { "banana", "apple", "graphes" };
            ViewData["var3"] = arry;

            ViewData["var4"] = new List<string>()
            {
                "cricket",
               "football",
               "hockey",
            };

            Student str = new Student();
            str.name = "saifullah";
            str.gender = "Male";
            str.standard = 5;

            ViewData["var5"] = str;
            return View();
        }
    }
}
