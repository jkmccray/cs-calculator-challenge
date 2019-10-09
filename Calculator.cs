namespace CalculatorChallenge
{
    public class Calculator
    {
        public string operation { get; }
        public double answer { get; }
        public Calculator(int menuSelection, double num1, double num2)
        {
            switch (menuSelection)
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
                case 0:
                    break;
            }
        }
    }
}