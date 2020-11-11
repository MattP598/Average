using System;

namespace Average
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter third number: ");
            int z = Convert.ToInt32(Console.ReadLine());
            int average = (x + y + z) / 3;
            Console.WriteLine("The average of the three numbers is " + average);
        }
    }
}