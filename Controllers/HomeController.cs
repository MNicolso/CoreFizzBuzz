using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreFizzBuzz.Models;
using System.Text;

namespace CoreFizzBuzz.Controllers
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

        [HttpGet]
        public IActionResult Solve()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Solve(string minInput, string maxInput, string fizzInput, string buzzInput)
        {
            var fizz = Convert.ToInt32(fizzInput);
            var buzz = Convert.ToInt32(buzzInput);
            var min = Convert.ToInt32(minInput);
            var max = Convert.ToInt32(maxInput);

            var result = new StringBuilder();

            for (int i = min; i < max; i++)
            {
                var fizzRemainder = (i % fizz);
                var buzzRemainder = (i % buzz);

                if (fizzRemainder == 0 && buzzRemainder == 0)
                {
                    result.Append("FIZZBUZZ!");
                }
                else if (fizzRemainder == 0)
                {
                    result.AppendLine("FIZZ! ");
                }
                else if (buzzRemainder == 0)
                {
                    result.AppendLine("BUZZ!");
                }
                else
                {
                    result.AppendLine($"{i}");

                }
            }
            @ViewData["Result"] = result;
            return View();
        }
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

//var range = Enumerable.Range(minInput, maxInput);
//var numberArray = string.Join(",", range.ToArray());
//for (int i = 0; i < maxInput; i++)
//{
//    var fizzRemainder = (i % fizzInput);
//    var buzzRemainder = (i % buzzInput);

//    if (fizzRemainder == 0 && buzzRemainder == 0)
//    {
//        numberArray[i].Equals("FIZZBUZZ!");
//    }
//    else if (fizzRemainder == 0)
//    {
//        numberArray[i].Equals("FIZZ! ");
//    }
//    else if (buzzRemainder == 0)
//    {
//        numberArray[i].Equals("BUZZ! ");
//    }


