namespace CalculatorApp.Services
{
    public interface ICalculationService
    {
        double Add(CalculatorInputs values);
        double Subtract(CalculatorInputs values);
        double Multiply(CalculatorInputs values);
        double Divide(CalculatorInputs values);
    }
    public class CalculationService : ICalculationService
    {
        public double Add(CalculatorInputs values) => values.val1 + values.val2;
        public double Subtract(CalculatorInputs values) => values.val1 - values.val2;
        public double Multiply(CalculatorInputs values) => values.val1 * values.val2;
        public double Divide(CalculatorInputs values) => values.val1 / values.val2;
    }
}
