using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanio = 0;
            char continuar;
            
        do
        {
            Console.WriteLine("Ingrese la altura de la piramide:");
            if(int.TryParse(Console.ReadLine(), out tamanio))
            {
                for(int i=tamanio; i>=0 ; i-- )
                {
                    for (int j=0; j<tamanio-i; j++)
                    {
                     Console.Write("*");
                    }
                    Console.WriteLine();                
                }

            }
            else
            {
            Console.WriteLine("Valor ijgresado incorrecto");
            }

           
            
            Console.WriteLine ("presione s para continuar");
            continuar=Console.ReadKey ().KeyChar;
               
        }  while (continuar == 's' || continuar == 'S');
 
           
          
        }
    }
}
