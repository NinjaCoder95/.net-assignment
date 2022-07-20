using Microsoft.AspNetCore.Mvc;
using CalculatorApp.Services;

namespace CalculatorApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculationController : ControllerBase
    {

        private readonly ICalculationService _result;

        public CalculationController(ICalculationService result)
        {
            _result = result;
        }

        [Route("Add")]
        [HttpPost]
        public double GetAdd(CalculatorInputs values)
        {
            return _result.Add(values);
        }

        [Route("Substract")]
        [HttpPost]
        public double GetSubtract(CalculatorInputs values)
        {
            return _result.Subtract(values);
        }

        [Route("Multiply")]
        [HttpPost]
        public double GetMultiply(CalculatorInputs values)
        {
            return _result.Multiply(values);
        }

        [Route("Divide")]
        [HttpPost]
        public double GetDivide(CalculatorInputs values)
        {
            return _result.Divide(values);
        }
    }
}
