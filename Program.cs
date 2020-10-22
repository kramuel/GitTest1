using System;

namespace GitTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Hello Samuel!");
                Console.WriteLine("how are you today?");

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("{0}^2 = {1}", i, i * i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("något hände");
                //throw;
            }


            Console.ReadKey();
        }
    }
}
