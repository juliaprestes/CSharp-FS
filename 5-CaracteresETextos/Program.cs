using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - caracteres e textos");

            //character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61; //cast
            Console.WriteLine(primeiraLetra); //caracter visto na tabela ascii

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "teste teste teste";
            Console.WriteLine(titulo);
            string cursosProgramacao = 
@"- .NET 
- Java
- Javascript"; // @considera o bloco todo como uma string

            Console.WriteLine(cursosProgramacao);


            Console.ReadLine();
        }
    }
}
