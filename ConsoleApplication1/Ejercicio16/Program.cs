using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
           Alumno nuevo_alumno;
           Alumno nuevo_alumno1;
           Alumno nuevo_alumno2;

           
           //byte nota1;
           //byte nota2;

            nuevo_alumno = new Alumno();
            nuevo_alumno.nombre = "Leandro";
            nuevo_alumno.apellido = "Lopez";
            nuevo_alumno.legajo = 1;
            nuevo_alumno.Estudiar(2, 3);
            nuevo_alumno.CalcularFinal();
            nuevo_alumno.Mostrar();

            Console.WriteLine("");

            nuevo_alumno1 = new Alumno();
            nuevo_alumno1.nombre = "Mario";
            nuevo_alumno1.apellido = "Luis";
            nuevo_alumno1.legajo = 2;
            nuevo_alumno1.Estudiar(5, 8);
            nuevo_alumno1.CalcularFinal();
            nuevo_alumno1.Mostrar();

            Console.WriteLine("");

            nuevo_alumno2 = new Alumno();
            nuevo_alumno2.nombre = "Juan";
            nuevo_alumno2.apellido = "Perez";
            nuevo_alumno2.legajo = 3;
            nuevo_alumno2.Estudiar(8, 9);
            nuevo_alumno2.CalcularFinal();
            nuevo_alumno2.Mostrar();

            Console.ReadKey();
               /*nuevo_alumno = new Alumno();

               

               Console.WriteLine("Ingrese el nombre;");
               nuevo_alumno.nombre= Console.ReadLine();
               Console.WriteLine("Ingrese el apellido;");
               nuevo_alumno.apellido = Console.ReadLine();
               Console.WriteLine("Ingrese el legajo;");
               while (!int.TryParse(Console.ReadLine(), out nuevo_alumno.legajo))
               {
                   Console.WriteLine("Re Ingrese el Legajo:");
               }
               Console.WriteLine("Ingrese La primer nota;");
               while (!byte.TryParse(Console.ReadLine(), out nota1))
               {
                   Console.WriteLine("Re Ingrese nota:");
               }
               Console.WriteLine("Ingrese La Segunda nota;");
               while (!byte.TryParse(Console.ReadLine(), out nota2))
               {
                   Console.WriteLine("Re Ingrese nota:");
               }

               nuevo_alumno.Estudiar(nota1, nota2);
               nuevo_alumno.CalcularFinal();

               nuevo_alumno.Mostrar();*/
              

          
        }
    }
}
