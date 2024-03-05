namespace assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //set up all the variables
            Console.WriteLine("Enter number of working hours: ");
            string input = Console.ReadLine();
            double hours = Convert.ToDouble(input);
            Console.WriteLine("Enter number of years: ");
            input = Console.ReadLine();
            double years = Convert.ToDouble(input);
            Console.WriteLine("Enter number of failures: ");
            input = Console.ReadLine();
            double failures = Convert.ToDouble(input);

            if(hours > 10000 || years >= 7 || failures > 25)
            {
                Console.WriteLine("Machine needs to be replaced");
            }
            else
            {
                Console.WriteLine("Machine does not need to be replaced");
            }
        }
    }
}