using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        

        byte _nota1;
         byte _nota2;
        float _notaFinal;
        public  string apellido;
        public  int legajo;
        public  string nombre;

        

        public  void CalcularFinal()
        {
            Random r = new Random();
           
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                this._notaFinal = r.Next(0, 10);
            }
            else
            {
                this._notaFinal = -1;
            }
            
        }

        public void Estudiar(byte notaUno,byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;

        }

        public void Mostrar()
        {

            Console.WriteLine("Nombre:{0} ", this.nombre);
            Console.WriteLine("Apellido:{0} ", this.apellido);
            Console.WriteLine("Legajo:{0} ", this.legajo);
            if (this._notaFinal != -1)
            {
                Console.WriteLine("Nota:{0} " , this._notaFinal);
            }

        }

       
    }
}
