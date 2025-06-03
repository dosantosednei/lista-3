using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_3_exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t;

            for (t = 1; t <= 10; t= t + 1)
            {
                Console.WriteLine("5 x {0} = {1}", t, 5 * t);
            }
        }
    }
}
