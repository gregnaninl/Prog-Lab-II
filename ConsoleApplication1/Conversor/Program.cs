using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public  class Program
    {
        static void Main(string[] args)
        {
            double Num1;
            string NumBin;
            bool x;


            NumeroDecimal numeroA = 10;
            NumeroBinario numeroB = "0010" ;

            Console.WriteLine("El numero decimal ingresado: 10\nEl numero Binario ingresado:0010");

            Num1 = numeroA + numeroB;
            Console.WriteLine("Suma en decimal:{0}",Num1);
            NumBin = numeroB + numeroA;
            Console.WriteLine("Suma en Binario:{0}",NumBin);

            Num1 = numeroA - numeroB;
            Console.WriteLine("la Resta decimal:{0}", Num1);
            NumBin = numeroB - numeroA;
            Console.WriteLine("Resta en Binario:{0}", NumBin);

            x = numeroA == numeroB;
            Console.WriteLine("Los numero son iguales:{0}",x);
            x = numeroA != numeroB;
            Console.WriteLine("Los numero son distinto:{0}", x);


            Console.ReadKey();
            
            
          





        }
    }
}
