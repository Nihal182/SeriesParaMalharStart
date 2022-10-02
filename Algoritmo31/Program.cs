using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo31
{
    internal class Program
    {
        static void Main(string[] args)
            /*Crie um algoritmo que mostre a média aritmética entre três números fornecidos
pelo usuário.*/
        {
            Console.WriteLine("Digite o primeiro número:");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            double number3 = double.Parse(Console.ReadLine());
            double mediaAri = (number1 + number2 + number3) / 3;
            Console.WriteLine($"A média dos números {number1}, {number2} e {number3} é igual a: {mediaAri}");
            Console.ReadKey();


        }
    }
}
