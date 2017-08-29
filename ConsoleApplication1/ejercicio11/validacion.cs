using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class validacion
    {
        public static  bool Validar(int min , int max, int num)
        {
            bool x;

            if (num >= min && num <= max)
            {
                x = true;
            }
            else
            {
                x = false;
            }
            return x;
        }
    }
}
