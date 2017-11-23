using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Corredor
    {
        protected static Random avance;
        protected eCarril carrilElegido;
        short velocidadMax;        
        
        public enum eCarril { Carril_1, Carril_2 };


        #region propiedades
        public eCarril CarrilElegido
        {
            get
            {
                return this.carrilElegido;
            }
        }

        public short VelocidadMaxima
        {
            get
            {
                return this.velocidadMax;
            }
            set
            {
                if (value <= 10)
                {
                    velocidadMax = value;
                }
                else
                {
                    velocidadMax = 10;
                }
            }
        }
        #endregion

        #region Constructores

         static Corredor()
        {
            avance = new Random();
        }

        public Corredor(short velocidadMaxima, eCarril carril)
        {
            this.VelocidadMaxima = velocidadMax;
            this.carrilElegido = carril;
        }

        #endregion

        #region Metodos

        public abstract void Correr();

        public virtual void Guardar(string path)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}
