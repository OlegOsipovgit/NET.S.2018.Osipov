﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    public interface IPredicate
    {
       bool IsMatch(int number);
     }
}

