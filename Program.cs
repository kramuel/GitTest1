using System;

namespace GitTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Samuel!");
            Console.WriteLine("how are you today?");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}^2 = {1} ", i, i * i);
                Console.WriteLine("\t{0}^3 = {1} ", i, i*i*i );
            }


            Console.ReadKey();
        }
    }
}
