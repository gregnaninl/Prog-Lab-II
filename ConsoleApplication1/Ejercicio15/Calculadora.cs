using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double Calcular(double num1 ,double num2,char operacion)
        {
            double resultado=0;
          

            switch (operacion)
            {
                case '+':
                    resultado = num1 + num2;
                                      
                    break;
                case '-':
                    resultado = num1 - num2;
                   
                    break;
                case '*':
                    resultado = num1 * num2;
                   
                    break;
                case '/':
                    if (Validar(num2) == false)
                    {
                        resultado = num1 / num2;
                       
                    }
                    else
                    {                 
                        resultado = double.NaN;
                    }
                    break;
                default:
                    resultado = double.NaN;
                    break;
            }


            return resultado;
        }


        static private bool Validar(double num)
        {
            bool resultado = false;

            if (num == 0)
            {
                resultado = true;
            }
            return resultado;
        }


        public static void Mostrar(double valor)
        {
            
            if (!double.IsNaN(valor))
            {
                Console.WriteLine();
                Console.WriteLine("\nEl resultado de la operacion es:{0}", valor);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("\nERROR");
            }
            
                  
        }


    }
}
