using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            int numero;

             do
            {
                Console.WriteLine("Ingrese un numero");
                while (int.TryParse(Console.ReadLine(), out numero) != true)
                {
                    Console.WriteLine("Valor ingresado incorrecto");
                }
                
                 
                 Console.WriteLine("presione s para continuar");
                continuar = Console.ReadKey().KeyChar;

            } while (ValidarRespuesta.ValidaS_N(continuar) == true);

        }
    }
}
