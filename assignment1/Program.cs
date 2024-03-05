namespace assignment1
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

            Console.Write("highest value is: ");
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else 
            {
                Console.WriteLine(secondNumber);
            }

            Console.Write("lowest value is: ");
            if (firstNumber < secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
        }
    }
}