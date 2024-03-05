using System.Globalization;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            const int amountOfNumbers = 3;

            Console.WriteLine("Enter first number: ");
            string firstInput = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstInput);
            Console.WriteLine("Enter second number: ");
            string secondInput = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondInput);
            Console.WriteLine("Enter third number: ");
            string thirdInput = Console.ReadLine();
            double thirdNumber = Convert.ToDouble(thirdInput);

            double sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine($"sum = {sum}");
            double average = (firstNumber + secondNumber + thirdNumber) / amountOfNumbers;
            Console.WriteLine($"average = {average:0.00}");
            double product = (firstNumber * secondNumber * thirdNumber);
            Console.WriteLine($"product = {product}");

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"highest = {firstNumber}");
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"highest = {secondNumber}");
            }
            else
            {
                Console.WriteLine($"highest = {thirdNumber}");
            }

            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                Console.WriteLine($"lowest = {firstNumber}");
            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                Console.WriteLine($"lowest = {secondNumber}");
            }
            else
            {
                Console.WriteLine($"lowest = {thirdNumber}");
            }
        }
    }
}