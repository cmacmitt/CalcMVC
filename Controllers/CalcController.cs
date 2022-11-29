using Microsoft.AspNetCore.Mvc;

namespace CalcMVC.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Add(int num1, int num2)
        {
            int result = num1 + num2;
            ViewBag.Result = result;
            return View();
        }

        public IActionResult Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            ViewBag.Result = result;
            return View();
        }

        public IActionResult Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            ViewBag.Result = result;
            return View();
        }

        public IActionResult Divide(int num1, int num2)
        {
            if (num2 != 0)
            {
                ViewBag.Result = num1 / num2;
            }
            else
            {
                return Content("<h2>You cannot divide by zero</h2>", "text/html");
            }
            return View();
        }
    }
}
