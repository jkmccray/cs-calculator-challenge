using System;

namespace CalculatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculatron 3000!");
            Console.WriteLine("1) Add two numbers");
            Console.WriteLine("2) Subtract two numbers");
            Console.WriteLine("3) Multiply two numbers");
            Console.WriteLine("4) Divide two numbers");
            Console.WriteLine("0) Exit");
            Console.WriteLine();
            Console.Write("> ");

            int menuSelection = int.Parse(Console.ReadLine());

            while (menuSelection != 0)
            {
            Console.Write("Please enter the first number ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Please enter the second number ");
            double secondNumber = double.Parse(Console.ReadLine());

            double answer = 0;
            string operation = "";

            switch (menuSelection)
            {
                case 1:
                    answer = firstNumber + secondNumber;
                    operation = "adding";
                    break;
                case 2:
                    answer = firstNumber - secondNumber;
                    operation = "subtracting";
                    break;
                case 3:
                    answer = firstNumber * secondNumber;
                    operation = "multiplying";
                    break;
                case 4:
                    answer = firstNumber / secondNumber;
                    operation = "dividing";
                    break;
                case 0:
                    break;
            }
            if (menuSelection != 0)
            {
                Console.WriteLine($"The result of {operation} {firstNumber} and {secondNumber} is {answer}");
            }

            Console.WriteLine("--------------------");
            Console.Write("Choose another option> ");
            menuSelection = int.Parse(Console.ReadLine());
            }




        }
    }
}
