using System;

namespace par_impar
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            int n1, n2, soma;

            Console.WriteLine("escreva o primeiro número!");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escreva o segundo número!");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("ola voce digitou {0} e {1} a soma dos algarismos é {2}", n1, n2, soma);

            if (soma % 2 == 0)
            
                Console.WriteLine("o numero é par!");
            
            else 
                Console.WriteLine("o numero é ímpar");

            Console.ReadKey();

        }
    }
}
