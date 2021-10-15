using System;

namespace ExercicioAliquota
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3900.0;
            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("Seu IR é de 7.5% e pode deduzir na declaração o valor de R$ 142,00 ");
            }
            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("Seu IR é de 15% e pode deduzir R$ 350,00");
            }
            else if(salario >= 3751.01 && salario <= 4664.0)         
            {
                Console.WriteLine("Seu IR é de 22.5%, pode deduzir R$ 636,00");
            }

            Console.ReadLine();
        }

    }
}
