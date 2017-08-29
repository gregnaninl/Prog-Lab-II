using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_4
{
     class Program
    {
        static void Main(string[] args)
        {
            long resultado = 0;
            string cadena;
            int cantidadNum = 0;
         
            
            Sumador calc = new Sumador();
            Sumador calc1 = new Sumador();

            calc.sumador();
            
            resultado = calc.Sumar(80,10);
            Console.WriteLine(resultado);
            Console.WriteLine("cantidad de sumas:{0}", cantidadNum = calc.cantidad());
           
            resultado = calc.Sumar(50, 50);
            Console.WriteLine(resultado);
            Console.WriteLine("cantidad de sumas:{0}", cantidadNum = calc.cantidad());

                       

            Console.WriteLine(" ");

            calc1.sumador(10);
           
            
            cadena = calc1.Sumar("LLL^ç", "lea");
            Console.WriteLine(cadena);
            Console.WriteLine("cantidad de sumas:{0}", cantidadNum = calc1.cantidad());
            
            cadena = calc1.Sumar("nono", "haha");
            Console.WriteLine(cadena);
            Console.WriteLine("cantidad de sumas:{0}", cantidadNum = calc1.cantidad());

            resultado= calc.sumaContadores(calc, calc1);
            Console.WriteLine("sumadores: {0}",resultado);
            
            Console.ReadKey();
           

      }
    }
}
