using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lista_3_exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int i;

            Console.Write("digite um valor: ");
            valor = int.Parse(Console.ReadLine()); 

            while (valor <= 0)
            {

            }
            Console.WriteLine("Tabuada do numero: {0}", valor);
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{valor} x {i} = {valor * i}");
            }
            
            
            
                
                

               
                 
                
                
                  
               


            


            


            

            

            
            


            
        }
    }
}
