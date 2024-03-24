﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Rectangle : Shape
    {
        public Rectangle(IShapeColor color) : base(color)
        { }
        public override void applyColor()
        {
            Console.Write("Rectangle Filled with: ");
            color.fillColor();
        }
    }
}
