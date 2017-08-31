using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Conversor
    {

        public static string DecimalBinario(double numero)
        {
            string binario = "";

            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    numero = (int)numero / 2;
                }

                //Console.WriteLine("El numero Binario es:" +binario);
            }
            else
            {
                if (numero == 0)
                {
                    binario = "0000";
                    //Console.WriteLine("El numero Binario es: 0000");
                }
                else
                {
                    Console.WriteLine("No se puede convertir ese numero");
                }
            }

            return binario;
         }
        public static int BinToDec(string binary)
        {
            int exponente = binary.Length - 1;
            int num_decimal = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (int.Parse(binary.Substring(i, 1)) == 1)
                {
                    num_decimal = num_decimal + int.Parse(System.Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }
            return num_decimal;
        }
    
    
    }



}
