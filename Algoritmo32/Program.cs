using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"O número digitado é {numero} e esse número é do tipo INTEIRO");
            Console.ReadKey();
        }
    }
}
