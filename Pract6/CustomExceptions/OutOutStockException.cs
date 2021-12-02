using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    public class OutOutStockException : Exception
    {
        public OutOutStockException()
        {
        }
        public OutOutStockException(string message) 
            : base(message)
        {
        }
        public OutOutStockException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
