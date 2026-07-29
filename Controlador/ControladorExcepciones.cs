using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorExcepciones : ApplicationException
    {
        public ControladorExcepciones(string mensaje, Exception original)
           : base(mensaje, original)
        {

        }
        public ControladorExcepciones(string mensaje)
            : base(mensaje)
        {

        }
    }
}
