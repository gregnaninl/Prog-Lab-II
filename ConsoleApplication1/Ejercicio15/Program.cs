using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir = 's';
            double num1 = 0;
            double num2 = 0;
            char operacion;
            double resultado = 0;
           

            while (seguir == 's')
            {

                Console.WriteLine("Ingrese un numero:");
              while(!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Re Ingrese el numero:");
                }

               Console.WriteLine("Ingrese el siguiete numero:");
               while(!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Re Ingrese el numero:");
                }
                
                Console.WriteLine("Ingrese la operacion a realizar:");
                operacion = Console.ReadKey().KeyChar;

                resultado = Calculadora.Calcular(num1, num2, operacion);
                
                Calculadora.Mostrar(resultado);
               
                

             Console.WriteLine("presione s para continuar");
             seguir = Console.ReadKey().KeyChar;
             Console.Clear();
            }
        }
    }
}
