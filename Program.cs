using System;

namespace Exercícios_em_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            Console.WriteLine("Digite o número A");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número B");
            int B = int.Parse(Console.ReadLine());

            int soma;
            soma = A + B;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
