using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
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
                        binario = "0" +binario;
                    }
                    else
                    {
                        binario = "1" +binario;
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
    }
}
