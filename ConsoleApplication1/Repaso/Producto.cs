using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string _marca;
        private float _precio;
        private string _codigoDeBarra;


        public string GetMarca()
        { 
        return _marca;
        }

        public float GetPrecio()
        {
            return _precio;
        }


        public static string MostrarProducto(Producto A)
        {
            string auxP;
            auxP = A._marca + ',' + A._precio + ',' + A._codigoDeBarra;
            return auxP;
        }


        public static bool operator == (Producto A, Producto B)
        {
            bool aux = false;

            bool result = A._marca.Equals(B._marca, StringComparison.Ordinal);
            bool result1 = A._codigoDeBarra.Equals(B._codigoDeBarra, StringComparison.Ordinal);

            if (result == result1)
            {
                aux = true;
            }
            return aux;
        }

        public static bool operator ==(Producto A, string B)
        {
            bool aux = A._marca.Equals(B, StringComparison.Ordinal);
            
            return aux;
        }


    }
}
