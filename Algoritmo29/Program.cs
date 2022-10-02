using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo29
{
    internal class Program
    {
        static void Main(string[] args)

        /*Crie um programa que leia o nome e mostre o nome.*/

        {
            Console.WriteLine("Digite o seu nome:");
            String name = Console.ReadLine();
            Console.WriteLine($"O seu nome é: {name}");
            Console.ReadKey();
        }
    }
}
