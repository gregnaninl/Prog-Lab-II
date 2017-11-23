using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class NoSeGuardoException :Exception
    {
        static string msj = "No se pudo Guardar el Archivo";
       
        public NoSeGuardoException()
            : base(msj)
        {

        }
        public NoSeGuardoException(string message)
            : this(message, null)
        {

        }
        public NoSeGuardoException(Exception e)
            : base(msj, e)
        {

        }
        public NoSeGuardoException(string message, Exception e)
            : base(msj + message, e)
        {

        }


    }
}
