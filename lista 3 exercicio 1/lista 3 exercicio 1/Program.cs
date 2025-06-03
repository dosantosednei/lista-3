using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_3_exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.Write(" digite um valor positivo");
            valor = int.Parse(Console.ReadLine());

            while (valor <= 0)
            {
                Console.WriteLine("valor inválido, informe outro valor:");
                valor = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("valor positivo");
            
            
               
           


          

            
            

            
            
                
            
            
               
        }
    }
}
