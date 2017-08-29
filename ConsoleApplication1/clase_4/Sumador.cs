using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_4
{
    public  class Sumador
    {
         int cantidadSumas;


        /// <summary>
        /// Inicializa el contador en cero.
        /// </summary>
        public  void sumador()
        {
            this.cantidadSumas = 0;
            
        }

        /// <summary>
        /// inicializa el sumador con el valor ingresado.
        /// </summary>
        /// <param name="num"></param>
        public   void sumador(int num)
        {
            this.cantidadSumas = num;
        }
        
        /// <summary>
        /// Dvuelve la suma de 2 numeros long.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public  long Sumar(long a, long b)
        {
            long x = 0;

            x = a + b;
            cantidadSumas++;
           
            return x;
        }

        /// <summary>
        /// concatena 2 string.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public  string Sumar(string a, string b)
        {
            string x;

            x = a + b;
            cantidadSumas++;
            return x;
        }
        /// <summary>
        /// devuelve un int con la cantidad de sumas.
        /// </summary>
        /// <returns></returns>
        public   int cantidad()
        {
             return cantidadSumas;
        }

       
       public static explicit operator long ( Sumador a)
       { 
            long x;

            x = (long) a.cantidadSumas;

            return x;
        }

        public static long operator + (Sumador a, Sumador b)
        {
            long x;

            x = (long) a + b.cantidadSumas;
 

            return x;        
        }

        public  long sumaContadores(Sumador a, Sumador b)
        {
            long x;
            x = a + b;
            return x;

        }

    }
}
