namespace OOP_Principles___Part_2.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Rectangle:Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }
        public override double CalculateSurface()
        {
            return base.Width * base.Height;
        }
    }
}
