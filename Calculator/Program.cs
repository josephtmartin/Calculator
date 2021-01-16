using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your operator then enter a comma separated list of numbers (example:* 1,2,3)");
            var numbers = Console.ReadLine();
            string[] seperateOperator = numbers.Split(" ");
            string[] splitArray = seperateOperator[1].Split(",");
            var product = 1;
            var sum = 0;
            var quotient = 0;
            string square = "";
            if (seperateOperator[0] == "*")
            {
                foreach (var n in splitArray)
                {
                    product *= int.Parse(n);
                }
                Console.WriteLine($"The Product = {product}");

            }
            if (seperateOperator[0] == "^2")
            {
                foreach (var n in splitArray)
                {
                    int Int = int.Parse(n);
                    int squaredInt = Int *= Int;
                    string squaredString = squaredInt.ToString();
                    square += $"{squaredString},";
                }
                Console.WriteLine($"Your squared numbers are {square.TrimEnd(',')}");
            }
            if (seperateOperator[0] == "+")
            {
                foreach (var n in splitArray)
                {
                    int Int = int.Parse(n);
                    sum += Int;
                }
                Console.WriteLine($"The sum of your numbers is {sum}");
            }
            if (seperateOperator[0] == "/")
            {
                foreach (var n in splitArray)
                {

                }
            }
        }
    }
}
