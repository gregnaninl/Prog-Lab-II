using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero = 0;
            double numero1 = 0;
            double area = 0;
            int opcion = 0;
            char seguir = 's';


            while (seguir == 's')
            {
                Console.WriteLine("Eliga una opcion:");
                Console.WriteLine("1. Calcular Area cuadrado");
                Console.WriteLine("2. Calcular Area triangulo");
                Console.WriteLine("3. Calcular Area circulo");
                Console.WriteLine("4.Salir");
               
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el valor de lado:");
                        if (double.TryParse(Console.ReadLine(), out numero) == true)
                        {
                            area = CalculoDeArea.CalcularCuadrado(numero);
                            if (area != 0)
                            {
                                Console.WriteLine("El valor de area es:{0}", area);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor ingresado incorrecto");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Ingrese el valor de la base:");
                         double.TryParse(Console.ReadLine(), out numero);

                        Console.WriteLine("Ingrese el valor de la altura:");
                        double.TryParse(Console.ReadLine(), out numero1);

                        
                            area = CalculoDeArea.CalcularTriangulo(numero,numero1);
                            if (area != 0)
                            {
                                Console.WriteLine("El valor de area es:{0}", area);
                            }
                        
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el valor del radio:");
                        if (double.TryParse(Console.ReadLine(), out numero) == true)
                        {
                            area = CalculoDeArea.CalcularCirculo(numero);
                            if (area != 0)
                            {
                                Console.WriteLine("El valor de area es:{0}", area);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor ingresado incorrecto");
                        }
                        
                        break;
                    case 4:
                        seguir = 'n';
                        break;
                    default:
                        Console.WriteLine("Opcion ingresada incorrecta");
                        break;
                }
            }


        }
    }
}
