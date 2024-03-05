using System.Xml;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            string firstInput = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstInput);
            Console.WriteLine("Enter second number: ");
            string secondInput = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondInput);
            Console.WriteLine("Enter third number: ");
            string thirdInput = Console.ReadLine();
            double thirdNumber = Convert.ToDouble(thirdInput);

            if (firstNumber > thirdNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The third number is the smallest of the three");
            }
            else
            {
                Console.WriteLine("The third number is not the smallest of the three");
            }
        }
    }
}