using System;

namespace _6_AtribuicaoDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Executando o projeto 6!");

            int idade = 21;
            int idadeJulia = idade; // variavel idadeJulia guarda o valor da variavel idade

            idade = 20; //mesmo atribuindo outro valor a idadeJulia continuará a que foi atribuida anteriormente
            Console.WriteLine(idade);
            Console.WriteLine(idadeJulia);

            Console.ReadLine();
        }
    }
}
