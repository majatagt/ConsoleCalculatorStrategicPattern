

namespace ConsoleCalculator
{
    internal class Calculator
    {
        private IOperation? _operation;

        public void SetOperation(IOperation? operation)
        { 
            _operation = operation;

        }
        public double ExecuteOperation(double num1, double num2, char op)
        {
            if (_operation is null) 
            {
                Console.WriteLine("No operation defined");
                return 0;
            }
            return _operation.Calculate(num1, num2);
        }



    }
}
