using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apellido.Nombre.Div
{
    public class PrestamoDolar : Prestamo
    {

        PeriocidadDePago periodicidad;

        #region Propiedades

        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
           
        }


        #endregion

        #region Constructores

        public PrestamoDolar(float monto, DateTime vencimiento, PeriocidadDePago periodicidad)
        :base(monto,vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(PrestamoDolar prestamo, PeriocidadDePago periodicidad)
            : this(prestamo.Monto, prestamo.Vencimiento, periodicidad) { }




        #endregion

        #region Metodos


        /// <summary>
        /// decuelve en interes del prestamos
        /// </summary>
        /// <returns></returns>
        private float CalcularInteres()
        {
            float x = 0;
            switch (this.periodicidad)

            { 
                case PeriocidadDePago.Mensual:
                    x =  (this.monto * 25)/100;
                    break;
                case PeriocidadDePago.Bimenstral:
                    x =  (this.monto * 35) /100  ;
                    break;
                case PeriocidadDePago.Trimestral:
                    x =  (this.monto * 40) /100 ;
                   break;
                default:
                   x = this.monto;
                   break;
            
            }
            return x;
        }


        /// <summary>
        /// Cambia el vencimiento y calcula la diferencia de intereses
        /// </summary>
        /// <param name="nuevoVencimiento"></param>
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan ts = nuevoVencimiento - DateTime.Today;

            
            float diferencia = ts.Days;
            this.monto = this.monto + (diferencia *(float) 2.5 );
            this.Vencimiento = nuevoVencimiento;
        }

        /// <summary>
        /// retornan una cadena con los atributos del prenstamo
        /// </summary>
        /// <returns></returns>
        public override string Mostar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Prestamo Dolares");
            sb.AppendLine(base.Mostar());
            sb.AppendFormat("Periodicidad;{0}\nInteres:{1}\n", this.periodicidad, this.Interes);
            return sb.ToString();
        }

       

        #endregion

    }
}
