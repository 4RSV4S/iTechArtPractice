﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3
{
    interface IReportGenerator<T>
    {
        void UserSort(T[] array);
    }
}
