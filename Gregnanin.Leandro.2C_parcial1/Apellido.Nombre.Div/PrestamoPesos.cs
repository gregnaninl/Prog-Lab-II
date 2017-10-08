using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apellido.Nombre.Div
{
    public class PrestamoPesos : Prestamo
    {
        float porcentajeIntereses;

        public float Interes 
        {
            get
            {
                return CalcularInteres();
            }
            set
            {
                this.porcentajeIntereses = value;
            }
        }

        #region Constructor

        /// <summary>
        /// recibe le monto, vencimeinto y el interes
        /// </summary>
        /// <param name="monto"></param>
        /// <param name="vencimiento"></param>
        /// <param name="interes"></param>
        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
            :base(monto,vencimiento)
        {
            Interes = interes;
        }

        /// <summary>
        /// recibe un prestamo y el porcentage de interes
        /// </summary>
        /// <param name="prestamo"></param>
        /// <param name="porcentageinteres"></param>
        public PrestamoPesos(PrestamoPesos prestamo, float porcentageinteres)
            : this(prestamo.Monto, prestamo.Vencimiento, prestamo.Interes)
        {
            this.porcentajeIntereses = porcentageinteres;
        }



        #endregion


        #region Metodos


        /// <summary>
        /// retorna el interes del prestamo
        /// </summary>
        /// <returns></returns>
        private float CalcularInteres()
        {
           return (this.monto * this.porcentajeIntereses) /100; 
        }

        /// <summary>
        /// Cambia el vencimiento y calcula la diferencia de intereses
        /// </summary>
        /// <param name="nuevoVencimiento"></param>
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan ts = nuevoVencimiento - DateTime.Today;

            float diferencia = ts.Days;
            this.porcentajeIntereses = diferencia * (float) 0.25;
            this.Vencimiento = nuevoVencimiento;    
        }

        /// <summary>
        /// retornan una cadena con los atributos del prenstamo
        /// </summary>
        /// <returns></returns>
        public override string Mostar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Prestamo Pesos");
            sb.AppendLine( base.Mostar());
            sb.AppendFormat("Porcentaje int:{0}\nIntereses:{1}\n", this.porcentajeIntereses, this.Interes);
            return sb.ToString();
        }

        
        




        #endregion
    }
}
