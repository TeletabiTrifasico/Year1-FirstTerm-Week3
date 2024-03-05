using System.Diagnostics.Metrics;
using System.Globalization;

namespace assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //culture of the program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //set up all the variables
            Console.WriteLine("Enter weight (kg): ");
            string input = Console.ReadLine();
            double weight = Convert.ToDouble(input);
            Console.WriteLine("Enter lenght (cm): ");
            input = Console.ReadLine();
            double length = Convert.ToDouble(input);
            Console.WriteLine("Enter gender (male/female): ");
            string gender = Console.ReadLine();

            double max;
            double min;

            //calculations
            double bmi = weight/Math.Pow(length/100, 2);
            Console.WriteLine($"bmi-value: {bmi:0.0}");     //output bmi

            if (gender == "male")
            {
                max = 20 * Math.Pow(length / 100, 2);
                min = 25 * Math.Pow(length / 100, 2);
                Console.WriteLine($"normal bmi-values (min .. max): 20..25");
                Console.WriteLine($"healthy weight range: {max:0.0} .. {min:0.0}");
            }
            else
            {
                max = 19 * Math.Pow(length / 100, 2);
                min = 24 * Math.Pow(length / 100, 2);
                Console.WriteLine($"normal bmi-values (min .. max): 19..24");
                Console.WriteLine($"healthy weight range: {max:0.0} .. {min:0.0}");
            }
        }
    }
}