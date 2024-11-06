using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Polymorphism: The different operation functions (+,-,/,*) that take different form of shapes
// Inheritance: the object inherhets from the interface // Interface or class inheritence
// Encapulation: encapsulate the class methods in the class
// Abstraction: The interface IOperation is an interface, an abstract class
// SOLID: SRP Single Responsibility Princple - Used to calculate the single operations/calculate. Which is also strategy pattern.
// SOLID OCP: Open Close Princple - Extend 
// DI: SetOperation method


namespace ConsoleCalculator
{
    public class Addition : IOperation
    {

        public double Calculate(double num1, double num2)
        {
            return num1 + num2;
        }
    }
    public class Subtraction : IOperation

    {
        public double Calculate(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    public class Division : IOperation
    {
        public double Calculate(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException ex)
            { 
            Console.WriteLine($"Could not perform action. Denominator cannot be zero {ex}"); //string interpolation
                return 0;
            }
        }
    }

    public class Multiplication : IOperation
    {
        public double Calculate(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}

