using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            string binario="" ;
            int opcion = 0;
            char seguir = 's';
            
          
            while (seguir == 's')
            {
                Console.WriteLine("Eliga una opcion:");
                Console.WriteLine("1. Convertir un numero decimal a binario");
                Console.WriteLine("2. Convertir un Binario a decimal");
                Console.WriteLine("3.Salir");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese un numero Decimal:");
                        if (double.TryParse(Console.ReadLine(), out numero) == true)
                        {
                            binario = Conversor.DecimalBinario(numero);
                            Console.WriteLine(binario);
                        }
                        else
                        {
                        Console.WriteLine("Valor ingresado incorrecto");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        break;
                    case 3:
                        seguir = 'n';
                        break;
                   default:
                        Console.WriteLine("Opcion ingresada incorrecta");
                        break;
                }
            }


        }
    }
}
