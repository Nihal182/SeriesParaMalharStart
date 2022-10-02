using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo30
{
    internal class Program
    {
        static void Main(string[] args)
            /*Crie um algoritmo que leia dois números e mostre o produto deles.*/
        {
            Console.WriteLine("Digite o primeiro número inteiro:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro:");
            int number2 = int.Parse(Console.ReadLine());
            int soma = number1 + number2;
            Console.WriteLine($"A soma de {number1} + {number2} é igual a: {soma}");
            Console.ReadKey();
        }
    }
}
