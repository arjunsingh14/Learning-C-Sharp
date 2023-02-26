// See https://aka.ms/new-console-template for more information
namespace Calculator
{
    class Calculator
    {
        public static void Main () {
            Console.Write("First Num: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Operator: ");
            string op = Console.ReadLine();
            Console.Write("Second Num: ");
            double num2 = double.Parse(Console.ReadLine());
            double output;

            switch (op)
            {
                case "+":
                    output = num1 + num2;
                    break;
                case "-":
                    output = num1 - num2;
                    break;
                case "*":
                    output = num1 * num2;
                    break;
                case "/":
                    output = num1 / num2;
                    break;
                case "^":
                    output = Math.Pow(num1, num2);
                    break;
                default:
                    output = 0.0;
                    break;
            }
            Console.WriteLine(output);

        }


    }
}

