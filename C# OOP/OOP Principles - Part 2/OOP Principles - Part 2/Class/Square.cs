namespace OOP_Principles___Part_2.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Square:Shape
    {
        public Square(double side):base(side,side)
        {
        }

        public override double CalculateSurface()
        {
            return base.Width * this.Height;
        }
    }
}
