using System;

namespace multiplosDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Executando projeto multiplos de 3");
            for(numero =1; numero <=100; numero++)
            {
                if (numero % 3 == 0)
                    Console.Write(numero+" ");
            }

            Console.ReadLine();
        }
    }
}
