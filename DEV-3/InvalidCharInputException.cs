using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    public class InvalidCharInputException : Exception
    {
        public InvalidCharInputException (string message) : base(message)
        {

        }
    }
}
