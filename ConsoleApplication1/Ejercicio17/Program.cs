using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre;
            long nroCuenta;
            double saldo;
            Enum tipoInteres;

            Cuenta nueva_cuenta = new Cuenta();

            nueva_cuenta.setNombre("banco comafi");
            nueva_cuenta.setNroCuenta(10051085);
            nueva_cuenta.setSaldo(50000);
            nueva_cuenta.setTipoInteres(0);

            Console.WriteLine(nombre = nueva_cuenta.getNombre());
            Console.WriteLine( nroCuenta = nueva_cuenta.getNroCuenta());
            Console.WriteLine( saldo = nueva_cuenta.getSaldo() );
            Console.WriteLine(tipoInteres = nueva_cuenta.getTipoInteres());

            Console.ReadKey();
        
        }
    }
}
