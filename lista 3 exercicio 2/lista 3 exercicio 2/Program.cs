using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_3_exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;

            Console.Write("digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            while (valor1 >= valor2)
            {
                Console.WriteLine("digite novamente o segundo valor");
                valor2 = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("segundo valor maior");
        }
    }
}
