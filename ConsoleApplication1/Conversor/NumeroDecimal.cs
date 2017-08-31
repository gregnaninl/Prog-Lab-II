using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
   public  class NumeroDecimal
    {

        public  double numeroD;
        

        private NumeroDecimal(double auxDecimal)
        {
            this.numeroD = auxDecimal;
        }


        public static double operator + (NumeroDecimal A, NumeroBinario B)
       {
           double aux;        

           aux = Conversor.BinToDec( B.numeroB );

           aux =  A.numeroD  + aux;
           return aux;
       }

        public static double operator -(NumeroDecimal A, NumeroBinario B)
        {
            double aux;

            aux = Conversor.BinToDec(B.numeroB);

            aux = A.numeroD - aux;
            return aux;
        }

     public static bool operator == (NumeroDecimal A, NumeroBinario B)
        {
            double aux;
            bool result = false;

            aux = Conversor.BinToDec( B.numeroB);
           
            
            if (A.numeroD == aux)
            {
                result = true;
            }                     
            return result;
        }

        public static bool operator !=(NumeroDecimal A, NumeroBinario B)
        {
            double aux;
            bool result = false;

            aux = Conversor.BinToDec(B.numeroB );
            if (A.numeroD != aux)
            {
                result = true;
            }
            return result;
        }

        public static explicit operator double (NumeroDecimal A)
        {
            double x = 0;
            x = (double)A.numeroD;
            return x;        
        }

        public static implicit operator NumeroDecimal (double A)
        {
            NumeroDecimal x;

            x = new NumeroDecimal(A);

            return x;        
        }

    }
}
