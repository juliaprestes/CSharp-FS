using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto Fatorial!");
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = n * fatorial;
                Console.WriteLine(n + " fatorial = " + fatorial);
            }

            Console.ReadLine();

        }
    }
}
