﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr7
{
    interface IDemo
    {
        void Show();
        double Dlina();
        int X { get; }
        int Y { get; }
        int this[int i] { get; set; }
    }
}
