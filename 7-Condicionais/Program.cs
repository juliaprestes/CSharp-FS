using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 7 - Executando projeto sobre condicionais!");

            int idadeTabata = 16;
            int quantidadePessoas = 2;

            if(idadeTabata >= 18)
            {
                Console.WriteLine("Tabata é maior de idade, pode entrar.");
            } 
            else if(quantidadePessoas >=2)
            {
                Console.WriteLine("Tabata é menor de idade, mas está acompanhado,  pode entrar!");
            } else
            {
                Console.WriteLine("Tabata é menor de idade e não está acompanhada! não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
