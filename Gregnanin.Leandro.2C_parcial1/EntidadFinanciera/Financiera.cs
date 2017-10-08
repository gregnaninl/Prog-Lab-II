using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apellido.Nombre.Div;

namespace EntidadFinanciera
{
    public class Financiera
    {
        List<Prestamo> listaDePrestamo;
        string razonSocial;


        #region Propiedades

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamo;
            }
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }


        public float InteresesEnDolares
        {
            get
            {
                return CalcularIntereseGanados(TipoPrestamo.Dolares);
            }
        }


        public float InteresesEnPesos
        {
            get
            {
                return CalcularIntereseGanados(TipoPrestamo.Pesos);
            }        
        }

        public float InteresesTotales
        {
            get
            {
                return CalcularIntereseGanados(TipoPrestamo.Todos);
            }
        }

        #endregion

        #region constructores


        private Financiera()
        {
            this.listaDePrestamo = new List<Prestamo>();
        }

       
        public Financiera(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;
        }



        #endregion

        #region Metodos

        /// <summary>
        /// Ordena la Lista de prestamos
        /// </summary>
        public void OrdenarPrestamos()
        {
            this.listaDePrestamo.Sort(Prestamo.OrdenarPorFecha);        
        }

        /// <summary>
        /// retorna los intereses ganados segun el tipo de prestamo
        /// </summary>
        /// <param name="tipoPrestamo"></param>
        /// <returns></returns>
        public float CalcularIntereseGanados(TipoPrestamo tipoPrestamo)
        {
            float x = 0;
           foreach (Prestamo p in listaDePrestamo)
           {
            
            switch (tipoPrestamo)
            {
                case TipoPrestamo.Pesos:
                    if (p is PrestamoPesos)
                        x += ((PrestamoPesos)p).Interes;
                    break;
                case TipoPrestamo.Dolares :
                    if (p is PrestamoDolar)
                        x += ((PrestamoDolar)p).Interes;
                    break;
                default:
                    if (p is PrestamoPesos)
                    {
                        x += ((PrestamoPesos)p).Interes;
                    }
                    else
                    {
                        if (p is PrestamoDolar)
                        {
                            x += ((PrestamoDolar)p).Interes;
                        }
                    }
                    break;
            }
           }
           return x;
        
        }


        #endregion

        #region Sobrecarga


        /// <summary>
        /// Retorna True si la lista de prestamos contiene el prestamos pasado por parametro
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Financiera f1, Prestamo p2)
        {
            bool x = false;
            if(f1.listaDePrestamo.Contains(p2))
            {
                x=true;
            }
        return x;
        }

        /// <summary>
        /// Retorna True si la lista de prestamos no contiene el prestamos pasado por parametro
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Financiera f1, Prestamo p2)
        {
            bool x = false;
            if (!(f1==p2))
            {
                x = true;
            }
            return x;
        }


        /// <summary>
        /// Agrega a la lista el prestamo si este no esta en la lista
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Financiera operator +(Financiera f1, Prestamo p2)
        {
            if (f1 != p2)
            {
                f1.listaDePrestamo.Add(p2);
            }
            return f1;           
        }

        /// <summary>
        /// Elimina a un prestamo si este esta en la lista
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Financiera operator -(Financiera f1, Prestamo p2)
        {
            if (f1 == p2)
            {
                f1.listaDePrestamo.Remove(p2);
            }
            return f1;

        }
        

        /// <summary>
        /// Retorna una cadena con los datos de la financiera 
        /// </summary>
        /// <param name="financiera"></param>
        /// <returns></returns>

        public static explicit  operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(financiera.RazonSocial);
            sb.AppendFormat("Intereses Totales:{0}\nIntereses Pesos:{1}\nInteres Dolares:{2}\n\n", financiera.InteresesTotales, financiera.InteresesEnPesos, financiera.InteresesEnDolares);

            financiera.listaDePrestamo.Sort(Prestamo.OrdenarPorFecha);
            foreach (Prestamo p in financiera.ListaDePrestamos)
            {
              
                              
                if (p is PrestamoPesos)
                {
                    sb.AppendLine(   ((PrestamoPesos)p).Mostar());
                }
                else
                {
                    if (p is PrestamoDolar)
                    {
                      sb.AppendLine( ((PrestamoDolar)p).Mostar());
                    }
                }

            }

            return sb.ToString();        
        }

        /// <summary>
        /// reutiliza el metodo statico para mostrar los atributos de la funanciera y los prestamos
        /// </summary>
        /// <param name="financiera"></param>
        /// <returns></returns>
        public static string Mostar(Financiera financiera)
        {
            return (string)financiera;        
        }
        
        #endregion
    }
}
