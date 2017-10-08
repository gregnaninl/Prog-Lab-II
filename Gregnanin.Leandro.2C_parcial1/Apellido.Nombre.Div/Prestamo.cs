using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apellido.Nombre.Div
{
     public abstract class Prestamo
    {

         protected float monto;
         protected DateTime vencimiento;

         


        #region propiedades

         public float Monto
         {
             get
             {
                 return this.monto;
             }                        
         }

         public DateTime Vencimiento
         {
             get
             {
                 return this.vencimiento;
             }
             set
             {
                 if (value > DateTime.Today)
                 {
                     this.vencimiento = value;
                 }
                 else
                 {
                     this.vencimiento = DateTime.Today;
                 }
             
             }         
         }

        #endregion


        #region Constructores


         public Prestamo(float monto, DateTime vencimiento )
         {
             this.monto = monto;
             this.vencimiento = vencimiento;         
         }
                       

        #endregion

        #region Metodos
    

         /// <summary>
         /// ordena segun criterio los prestamos
         /// </summary>
         /// <param name="p1"></param>
         /// <param name="p2"></param>
         /// <returns></returns>
         public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
         {
             int x = 0;

             if (p1.Vencimiento == p2.Vencimiento)
             {
                 x = 0;
             }
             else
             {
                 if (p1.Vencimiento > p2.Vencimiento)
                 {
                     x = 1;
                 }
                 else
                 {
                     x = -1;
                 }
             }

             return x;
         }

         public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

         /// <summary>
         /// retornan una cadena con los atributos del prenstamo
         /// </summary>
         /// <returns></returns>
         public virtual string Mostar()
         {
             StringBuilder sb = new StringBuilder();

             sb.AppendFormat("Monto:{0}\nPlazo:{1}",this.Monto,this.Vencimiento);

             return sb.ToString();
         }


        #endregion



    }
}
