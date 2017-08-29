using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero = 0;
            int max = 0;
            int min = 0;
            int prom = 0;


            for (int i = 1; i < 11; i++)
            {

                Console.WriteLine("Ingrese un numero {0}:", i);
                while (int.TryParse(Console.ReadLine(), out numero) != true || validacion.Validar(-100, 100, numero) != true)
                {
                    Console.WriteLine("Valor ingresado incorrecto");
                }
                if (i == 1)
                {
                    min = numero;
                    max = numero;
                    prom = numero;
                }
                else
                {
                    if (max > numero)
                    {
                        max = numero;
                    }

                    if (min < numero)
                    {
                        min = numero;
                    }

                    prom = prom + numero;
                }              

            }

            prom = prom / 10;
            Console.Clear();
            Console.WriteLine("VALORES CALCULADOS\n\n-Valor maximo: {0}\n-Valor minimo: {1}\n-Valor promedio: {2}\n", min, max, prom);
            Console.ReadKey();
        }
    }
}
