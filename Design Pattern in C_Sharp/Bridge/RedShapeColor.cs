﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RedShapeColor : IShapeColor
    {
        public void fillColor()
        {
            Console.WriteLine("Red color");
        }
    }
}
