using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddNumbersActivity.Controllers
{
    public class AddNumbersController : Controller
    {
        // GET: AddNumbers
        public ActionResult Index(int num1 = 0, int num2 = 0)
        {
            int sum = num1 + num2;
            ViewBag.Message = "The answer is: " + sum;
            return View();
        }
    }
}