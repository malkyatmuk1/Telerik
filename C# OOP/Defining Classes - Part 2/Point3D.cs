using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2
{
    public struct Point3D
    {

        private static readonly Point3D startPoint;
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D StartPoint { get { return startPoint; } }

        static Point3D()
        {
            startPoint = new Point3D(0, 0, 0);
        }
        public Point3D(int x,int y,int z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
          public override string ToString()
        {
            StringBuilder stroitel = new StringBuilder();
            stroitel.Append(this.X).Append(" ").Append(this.Y).Append(" ").Append(this.Z).Append(" ");
            return stroitel.ToString();

        }

    }
}
