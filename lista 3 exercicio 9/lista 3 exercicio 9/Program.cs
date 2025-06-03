using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_3_exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int soma;
            int i;

            for (i = 1; i <=30; i++)
            {
                soma = n1 + n2;
                n2 = n1;
                n1  = soma;

                Console.WriteLine("a sequqencia de Fibonacci é :{0}", soma);


            }
                

                    




        }
    }
}
