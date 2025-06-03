using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_3_exercico_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma;
            int i;
            soma = 0;

            for (i = 1;  i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("a soma dos numeros de 1 a 100 é:{0}" , soma);
               
        }
    }
}
