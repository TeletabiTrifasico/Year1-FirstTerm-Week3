namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter score: ");
            string input = Console.ReadLine();
            double grade = Convert.ToDouble(input);

            if (grade >= 90) 
            {
                Console.WriteLine("grade: A");
                Console.WriteLine("course passed");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("grade: B");
                Console.WriteLine("course passed");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("grade: C");
                Console.WriteLine("course passed");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("grade: D");
                Console.WriteLine("course not passed");
            }
            else
            {
                Console.WriteLine("grade: F");
                Console.WriteLine("course not passed");
            }
        }
    }
}