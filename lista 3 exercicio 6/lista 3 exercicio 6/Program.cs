using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_3_exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a;
            int b;

            Console.Write("digite um numero positivo (x): ");
            x = int.Parse(Console.ReadLine());

            while (x <= 0)
            {
                Console.WriteLine(" erro, digite um numero positivo (x): ");
                x = int.Parse(Console.ReadLine()) ;
            }
            Console.Write("digite o valor do intervalo (A): ");
            a = int.Parse(Console.ReadLine()) ;

            Console.Write("digite o valor do intervalo (B) , que deve ser maior que (A): ");
            b = int.Parse(Console.ReadLine());

            while(b <= a)
            {
                Console.WriteLine("erro , (B) deve ser maior que (A) , digite o (B) novamente: ");
                b = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"tabuada do {x} de {b} até {a} (ordem decrescente): ");
            for (int i = b; i >= a; i--)
            {
                Console.WriteLine($"{x} x {i} = {x * i}");
            }


            
            

            

            
                


            
            

           
            

            
            
                               

                        
            

                               

        }
    }
}
