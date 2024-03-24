using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rec = new Rectangle(new RedShapeColor());
            rec.applyColor();

            Shape cir = new Circle(new BlueShapeColor());
            cir.applyColor();
        }
    }
}
