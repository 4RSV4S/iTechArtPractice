using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    public class OutOfStockException : Exception
    {
        public OutOfStockException()
        {
        }
        public OutOfStockException(string message) 
            : base(message)
        {
        }
        public OutOfStockException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
