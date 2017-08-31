using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
  public class NumeroBinario
    {
       public   string numeroB;

        private NumeroBinario(string auxBin)
        {
           this.numeroB = auxBin;        
        }

        public static string operator + (NumeroBinario B, NumeroDecimal A)
        {
            string result=" ";
            double aux = 0;

            aux = Conversor.BinToDec(B.numeroB);

            aux = A.numeroD + aux;

            result = Conversor.DecimalBinario(aux);            

            return result;
        }

        public static string operator - (NumeroBinario B, NumeroDecimal A)
        {
            string result = " ";
            double aux = 0;

            aux = Conversor.BinToDec(B.numeroB);

            aux = A.numeroD - aux;

            result = Conversor.DecimalBinario(aux);

            return result;
        }

        public static bool operator == (NumeroBinario B, NumeroDecimal A)
        {
            bool result = false;
            double aux = 0;

            aux = Conversor.BinToDec(B.numeroB);

            if (A.numeroD == aux)
            {
                result = true;
            }          

            return result;
        }

        public static bool operator != (NumeroBinario B, NumeroDecimal A)
        {
            bool result = false;
            double aux = 0;

            aux = Conversor.BinToDec(B.numeroB);

            if (A.numeroD != aux)
            {
                result = true;
            }

            return result;
        }

        public static explicit operator string (NumeroBinario B)
        {
            string x = " ";

            x = (string)B.numeroB;

            return x;
        }


        public static implicit operator NumeroBinario (string B)
        {
            NumeroBinario x;

            x = new NumeroBinario(B);
            
            return x;
        }

    }
}
