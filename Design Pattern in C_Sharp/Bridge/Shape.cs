using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Shape
    {
        protected IShapeColor color;
        public Shape(IShapeColor color)
        {
            this.color = color;
        }
        public abstract void applyColor();
    }
}
