namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number = Convert.ToInt32(Console.ReadLine());
            double factorial = 1;

            for(int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("The factorial of {0}, is {1}", number, factorial);
            Console.ReadLine();

        }
    }
}