using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
   
     
    public class Cuenta
    {
        public enum ETipoInteres { 
            TIN = 0, 
            TAE=1,
            TAR =2,
     };


        string _nombre;
        long nroCuenta;
        double _saldo;
        ETipoInteres _tipoInteres;


   /// <summary>
   /// retorna un string con el nombre.
   /// </summary>
   /// <returns></returns>
    public string getNombre()
    {
        return this._nombre;         
    }

    /// <summary>
    /// retorna un long con el numero de cuenta.
    /// </summary>
    /// <returns></returns>
        
    public long getNroCuenta()
    {
        return this.nroCuenta;    
    }

    
    /// <summary>
    /// retona un double con el valor del saldo.
    /// </summary>
    /// <returns></returns>
    public double getSaldo()
    {
        return this._saldo;
    }

    public ETipoInteres getTipoInteres()
    {
        return this._tipoInteres;
    }

    /// <summary>
    /// asigna el valor que se paso por referencia al nombre
    /// </summary>
    /// <param name="nombre"></param>
    public void setNombre(string nombre)
    {
        this._nombre = nombre;
    }

    /// <summary>
    /// asigna el valor que se paso por referencia al numero de cuenta.
    /// </summary>
    /// <param name="nombre"></param>   
    public void setNroCuenta(long nroCuenta)
    {
        this.nroCuenta = nroCuenta;
    }

    /// <summary>
    /// asigna el valor que se paso por referencia al saldo.
    /// </summary>
    /// <param name="saldo"></param>
    public void setSaldo(double saldo)
    {
        this._saldo = saldo;
    }

    /// <summary>
    /// asigna el valor que se paso por referencia a tipo Interes.
    /// </summary>
    /// <param name="tipoInteres"></param>
    public void setTipoInteres(ETipoInteres tipoInteres)
    {
        this._tipoInteres = tipoInteres;
    }

    }
}
