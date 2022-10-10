using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? exit = "";
            while (exit != "!quit")
            {
                Console.WriteLine("Введите a и b");

                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите операцию");
                var func = Console.ReadLine();
                bool operationSet = true;
                double result = OperationResult(func, a, b, ref operationSet);

                if (operationSet)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Пошёл нахуй");
                }

                Console.WriteLine("Хочешь выйти пидр, если да то введи !quit");
                exit = Console.ReadLine();
            }
        }

        private static double OperationResult(string? operation, double a, double b, ref bool operationSet)
        {
            double resultOp = 0;
            switch (operation)
            {
                case "/":
                    resultOp = MathFunc.Div(a, b);
                    break;
                case "+":
                    resultOp = MathFunc.Plus(a, b);
                    break;
                case "-":
                    resultOp = MathFunc.Sub(a, b);
                    break;
                case "*":
                    resultOp = MathFunc.Mult(a, b);
                    break;
                default:
                    operationSet = false;
                    break;
            }

            return resultOp;
        }
    }
}