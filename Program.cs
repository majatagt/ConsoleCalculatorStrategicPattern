namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args, Calculator calculator)
        {
            Console.WriteLine("Console Calculator");

            Console.WriteLine("Enter the first number: ");
            double num1 = GetValidNumber();
            Console.Write("Enter an operator (+, -, *, /) ");
            char op = GetValidOperator();
            Console.WriteLine("Enter the second number: ");
            double num2 = GetValidNumber();

            Calculator calculator = new Calculator();
            double result = calculator.ExecuteOperation(num1, num2, op);
            calculator.SetOperation(SelectOperation(op));

            Console.WriteLine($"\n Result: {num1} {op} {num2} = {result}");
        }

        private static IOperation? SelectOperation(char op)
        {
            switch (op) 
            {
                case '+':
                    return new Addition();
                case '-':
                    return new Subtraction();
                case '/':
                    return new Division();
                case '*':
                    return new Multiplication();
                default: 
                    return null;
            }
        }

        private static char GetValidOperator()
        {
            char op;
            while (true)
            {
                op = Console.ReadKey().KeyChar;
                if (op == '+' || op == '-' || op == '*' || op == '/')
                    break;
                Console.WriteLine("/n Invalid Operator. Please enter a valid operator");
            }
            return op;
           
        }
        private static double Calculate;

        private static double GetValidNumber()
        {
            double num;

            while (!double.TryParse(Console.ReadLine(), out num))
                {
                Console.WriteLine("Invalid Input. Please enter antoher number!");
                }
            return num;
        }
    }
}
