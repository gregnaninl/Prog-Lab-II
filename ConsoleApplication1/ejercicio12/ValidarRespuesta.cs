using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char respuesta)
         {
             bool x = false;
            
            
           /* while (respuesta != 's' && respuesta != 'n')
             {
                 Console.WriteLine("presione s o n");
                 respuesta = Console.ReadKey().KeyChar;
             }*/
                 
                 if (respuesta == 's')
                 {
                     x = true;
                 }
                 else
                 {
                     if (respuesta == 'n')
                     {
                         x = false;
                     }

                 }
             

             return x;
         
         }

    }
}
