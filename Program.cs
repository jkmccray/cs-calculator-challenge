﻿using System;

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
            Console.WriteLine("5) Get the square of a number");
            Console.WriteLine("6) Get the square root of a number");
            Console.WriteLine("7) Advanced option: Enter an expression");
            Console.WriteLine("0) Exit");
            Console.WriteLine();
            Console.Write("Choose a menu option> ");

            int menuSelection = -1;
            while (menuSelection < 0)
            {
                try
                {
                    menuSelection = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Select a number from 0 to 4. Try again>");
                    menuSelection = -1;
                }

                while (menuSelection > 0 && menuSelection < 8)
                {
                    string[] enteredNumbers;
                    double firstNumber = 0;
                    double secondNumber = 0;
                    string arithmeticOperator = "";

                    if (menuSelection <= 4)
                    {
                        try
                        {
                            Console.Write("Please enter two numbers with a space in between: ");
                            enteredNumbers = Console.ReadLine().Split(" ");
                            firstNumber = double.Parse(enteredNumbers[0]);
                            secondNumber = double.Parse(enteredNumbers[1]);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Must enter a number");
                        }
                    }

                    if (menuSelection == 5 || menuSelection == 6)
                    {
                        try
                        {
                            Console.Write("Please enter a number: ");
                            firstNumber = double.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Must enter a number");
                        }
                    }

                    if (menuSelection == 7)
                    {
                        try
                        {
                            Console.Write("Please enter an expression with a space in between each character: ");
                            enteredNumbers = Console.ReadLine().Split(" ");
                            firstNumber = double.Parse(enteredNumbers[0]);
                            arithmeticOperator = enteredNumbers[1];
                            secondNumber = double.Parse(enteredNumbers[2]);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Must enter a number");
                        }
                    }

                    Calculator calculator = new Calculator(menuSelection, firstNumber, secondNumber, arithmeticOperator);

                    if (double.IsInfinity(calculator.answer))
                    {
                        Console.WriteLine("Dividing by zero is not allowed");
                    }
                    if (firstNumber != 0 && secondNumber != 0)
                    {
                        Console.WriteLine($"The result of {calculator.operation} {firstNumber} and {secondNumber} is {calculator.answer}");
                    }
                    if (menuSelection == 5 || menuSelection == 6)
                    {
                        Console.WriteLine($"The {calculator.operation} of {firstNumber} is {calculator.answer}");
                    }
                    if (menuSelection == 7)
                    {

                    }

                    menuSelection = -1;
                    Console.Write("Choose another menu option> ");
                }
            }
        }
    }
}
