using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class Calculator : ControllerBase                    
    {
    [HttpGet]
    //Method to find Addition Numbers:
    public decimal Add(decimal x,decimal y){
        decimal result=x+y;
        return result;
    }
    [HttpGet]
    //Method to find Subtraction Numbers:
    public decimal Subtract(decimal x,decimal y){
        decimal result=x-y;
        return result;
    }
     [HttpGet]
    //Method to find Multiplication Numbers:
    public decimal Multiply(decimal x,decimal y){
        decimal result=x*y;
        return result;
    }
     [HttpGet]
    //Method to find Division Numbers:
    public ActionResult Divide(decimal x, decimal y)
    {
        if (y == 0)
        {
            return BadRequest("Cannot divide by zero.");
        }

        decimal result = x / y;
        return Ok(result);
    }
    [HttpGet]
    //Method to find modulo Numbers:
    public ActionResult Modulo(decimal x, decimal y)
    {
        if (y == 0)
        {
            return BadRequest("Cannot calculate quotient with zero divisor.");
        }

        decimal remainder = x % y;
        return Ok(remainder);
    }
    }
}
