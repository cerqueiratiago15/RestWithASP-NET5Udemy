using Microsoft.AspNetCore.Mvc;
using System;

namespace RestWithASP_NET5Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : Controller
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

        [HttpGet("multiply/{firstNumber}/{secondNumber}")]
        public IActionResult GetMultiply(string firstNumber, string secondNumber)
        {
            if (decimal.TryParse(firstNumber, out decimal number1) && decimal.TryParse(secondNumber, out decimal number2))
            {
                decimal mult = number1*number2;
                return Ok(mult);
            }

            return BadRequest("Invalid input");
        }
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult GetSub(string firstNumber, string secondNumber)
        {
            if (decimal.TryParse(firstNumber, out decimal number1) && decimal.TryParse(secondNumber, out decimal number2))
            {
                decimal mult = number1 - number2;
                return Ok(mult);
            }

            return BadRequest("Invalid input");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult GetDivision(string firstNumber, string secondNumber)
        {
            if (decimal.TryParse(firstNumber, out decimal number1) && decimal.TryParse(secondNumber, out decimal number2))
            {
                if (number2!=0)
                {
                    decimal mult = number1 / number2;
                    return Ok(mult); 
                }
                else return BadRequest("Number 2 can not be zero");
            }

            return BadRequest("Invalid input");
        }

        [HttpGet("squareRoot/{firstNumber}")]
        public IActionResult GetSquareRoot(string firstNumber)
        {
            if (decimal.TryParse(firstNumber, out decimal number1))
            {
                if (number1>=0)
                {
                    double sqrt = Math.Sqrt((double)number1);

                }
                else BadRequest("Number can not be negative");
            }

            return BadRequest("Invalid input");
        }
   
    }
}
