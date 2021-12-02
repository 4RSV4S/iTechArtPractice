﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    class NotFoundException : Exception
    {
        public NotFoundException()
        {
        }
        public NotFoundException(string message)
            : base(message)
        {
        }
        public NotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
