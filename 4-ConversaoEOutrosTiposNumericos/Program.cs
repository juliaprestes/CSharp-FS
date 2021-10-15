using System;

namespace _4_ConversaoEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4!");

            double salario = 1200.50;

            //int é um tipo de variavel que possui 32bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            //long é um tipo de variavel que possui 64 bits
            long idade = 12000000000;
            Console.WriteLine(idade);

            //o short é um tipo de variavel de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            // float não é muito preciso
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
