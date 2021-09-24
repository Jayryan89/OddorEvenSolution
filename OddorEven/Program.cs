using System;

namespace OddorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            var answer = Console.ReadLine();
            var value = Convert.ToInt32(answer);



            if (value % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}