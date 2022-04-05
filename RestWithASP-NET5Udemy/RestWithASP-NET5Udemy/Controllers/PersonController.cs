using Microsoft.AspNetCore.Mvc;
using System;

namespace RestWithASP_NET5Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSum(string firstNumber, string secondNumber)
        {
            if (decimal.TryParse(firstNumber, out decimal number1) && decimal.TryParse(secondNumber, out decimal number2))
            {
                decimal sum = number1 + number2;
                return Ok(sum);
            }

            return BadRequest("Invalid input");
        }
    }
}
