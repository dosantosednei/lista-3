using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_3_exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            
            for (i = 1; i <= 20; i++)
            {
                Console.Clear();
                
                Console.WriteLine($"tabuada do {i}: ");

                for ( j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i*j}");
                }
                Console.WriteLine("\npressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
