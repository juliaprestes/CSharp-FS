using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 8 - Executando projeto sobre condicionais2!");

            int idadeTabata = 16;
            int quantidadePessoas = 2;

            if (idadeTabata >= 18 || quantidadePessoas >= 2)
            {
                Console.WriteLine(" pode entrar.");
            }
            else
            {
                Console.WriteLine(" não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
