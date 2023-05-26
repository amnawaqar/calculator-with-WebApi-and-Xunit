using Microsoft.AspNetCore.Mvc;
using Calculatorclass;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
      
        [HttpGet(Name = "Add/{num1}/{num2}")]
        public int Get(int num1,int num2)
        {
         var calculator=new Calculator();
            return calculator.add(num1, num2);
        }
    }
}