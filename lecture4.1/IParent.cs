﻿using lecture4._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture4._1
{
    internal interface IParent
    {
        public bool GetChildren(out Person[] children);
        public void TakeCare();
    }
}
