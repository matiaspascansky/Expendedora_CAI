using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using
using Expendedora.Exceptions;

namespace Expendedora.Validaciones
{
    class Validaciones
    {
        public Double validarDouble(String str)
        {
            Double doubleValue;
            if (!double.TryParse(str, out doubleValue))
            {
                throw new WrongTypeException("no es un double");
            } else
            {
                return doubleValue;
            }
        }

        public int validarInteger(String str)
        {
            int intValue;
            if (!int.TryParse(str, out intValue))
            {
                throw new WrongTypeException("no es un int");
            }
            else
            {
                return intValue;
            }
        }
    }
}
