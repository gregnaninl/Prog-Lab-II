using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int cont = 0;

            Console.WriteLine("Ingrese un numero:");
            int.TryParse(Console.ReadLine(), out numero);

            for (int i = numero; i > 0; i--)
            {
                cont = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 1)
                {
                    Console.WriteLine(i);
                }
            
            }


            Console.ReadKey();
               

        }
    }
}
