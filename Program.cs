using System;

namespace GitTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Samuel!");
            Console.WriteLine("how are you today?");
            double d;
            for (int i = 0; i <= 10; i++)
            {
                d = i;
                Console.WriteLine("sqrt({0}) = {1:0.##} ", i, Math.Sqrt(d));

            }


            Console.ReadKey();
        }
    }
}
