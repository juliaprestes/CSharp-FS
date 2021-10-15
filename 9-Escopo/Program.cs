using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Executando projeto 9 - Escopo!");

            int idadeTabata = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
               mensagemAdicional = "Tabata esta acompanhada";
            }
            else
            {
                mensagemAdicional = "Tabata não está acompanhada";
            }
            if (idadeTabata >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine(" não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
