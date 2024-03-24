using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Circle : Shape
    {

        public Circle(IShapeColor color) : base(color)
        { }
        public override void applyColor()
        {
            Console.Write("Circle Filled with: ");
            color.fillColor();
        }
    }
}
