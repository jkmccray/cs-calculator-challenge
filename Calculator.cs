using System;

namespace CalculatorChallenge
{
    public class Calculator
    {
        public string operation { get; }
        public double answer { get; }
        public Calculator(int menuSelection, double num1, double num2, string arithmeticOperator)
        {
            int option = 0;
            if (menuSelection == 7)
            {
                switch (arithmeticOperator)
                {
                    case "+":
                        option = 1;
                        break;
                    case "-":
                        option = 2;
                        break;
                    case "*":
                        option = 3;
                        break;
                    case "/":
                        option = 4;
                        break;
                }
            }
            else
            {
                option = menuSelection;
            }
            switch (option)
            {
                case 1:
                    operation = "adding";
                    answer = num1 + num2;
                    break;
                case 2:
                    answer = num1 - num2;
                    operation = "subtracting";
                    break;
                case 3:
                    answer = num1 * num2;
                    operation = "multiplying";
                    break;
                case 4:
                    answer = num1 / num2;
                    operation = "dividing";
                    break;
                case 5:
                    answer = Math.Pow(num1, 2);
                    operation = "square";
                    break;
                case 6:
                    answer = Math.Sqrt(num1);
                    operation = "square root";
                    break;
                case 0:
                    break;
            }
        }
    }
}