using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_3_exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;

            Console.Write("digite o sexo: ");
            sexo = Console.ReadLine().ToUpper();

            while (sexo != "F" && sexo != "M")
            {
                Console.WriteLine("invàlido, digite novamente:");
                sexo = Console.ReadLine().ToUpper();    
            }
            if (sexo == "M")
            {
                Console.WriteLine("sexo masculino");
            }
            else
            {
                Console.WriteLine("sexo feminino");
            }




                



        }
    }
}
