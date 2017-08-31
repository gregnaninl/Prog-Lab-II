using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {

       public static double CalcularCuadrado(double num)
       {
           double area = 0;
            double pot = 2;

            if (num > 0)
            {
                area = Math.Pow(num, pot);

            }
            else {
                Console.WriteLine("El valor ingresado es incorrecto");
                
            }


            return area;
       }

       public static double CalcularTriangulo(double num1, double num2)
       {
           double area = 0;

           if (num1 > 0 && num2 > 0)
           {
               area = num1 * num2;
           }
           else
           {
               Console.WriteLine("El valor ingresado es incorrecto");
               
           }

           return area;
       
       }

       public static double CalcularCirculo(double num1)
       {
           double area = 0;
           double pot = 2;

           if (num1 > 0)
           {

               area = (Math.Pow(num1, pot))*Math.PI ;
           
           }
           else
           {
               Console.WriteLine("El valor ingresado es incorrecto");
           }

           return area;
       }


    }
}
