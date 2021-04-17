using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Exceptions
{
    class WrongTypeException : Exception
    {
        public WrongTypeException(string msg)
       : base(String.Format("Error", msg))
        {

        }

    }
}
