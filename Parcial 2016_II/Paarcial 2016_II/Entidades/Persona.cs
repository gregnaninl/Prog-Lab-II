using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
     public class Persona : Corredor
    {
         public delegate void CorrenCallback(int avance, Corredor corredor);

         public event CorrenCallback Corriendo; 

        string nombre;

        public Persona(string nombre, short velocidadMaxima, eCarril carril)
        :base(velocidadMaxima,carril)
        {
            this.nombre = nombre;
        }

        #region Metodos

         public override void Correr()
        {
            while (true)
            {
                Thread.Sleep(300);                         
                 Corriendo.Invoke(this.VelocidadMaxima, this);
            }
        }

         public override void Guardar(string path)
         {
             try
             {
             
                 using (System.IO.StreamWriter tx = new System.IO.StreamWriter(path, true))
                 {
                     tx.WriteLine(this.ToString());
                 }
                

             }
             catch (Exception e)
             {
                 throw new NoSeGuardoException(e.Message);
             }

         }

         public override string ToString()
         {
             return string.Format(this.nombre+" en carril "+this.CarrilElegido+" a una velocidad máxima de "+this.VelocidadMaxima);

         }

        #endregion

    }
}
