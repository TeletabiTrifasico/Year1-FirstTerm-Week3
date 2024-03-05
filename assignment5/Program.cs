namespace assignment5
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

            if (firstNumber % secondNumber == 0)
            {
                Console.WriteLine($"Number 1 is multiple of number 2");
            }
            else if (secondNumber % firstNumber == 0) 
            {
                Console.WriteLine("Number 2 is multiple of number 1");
            }
            else 
            {
                Console.WriteLine("Numbers are no multiples");
            }
        }
    }
}