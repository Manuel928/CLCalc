using System;

namespace CLCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
           double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Select an operator " + "(+ - * / %): ");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"RESULT = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"RESULT = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"RESULT = {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"RESULT = {num1 / num2}");
                    break;
                case "%":
                    Console.WriteLine($"RESULT = {num1 % num2}");
                    break;
            }
                
        }
    }
}
