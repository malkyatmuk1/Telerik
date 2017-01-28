using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Defining_Classes___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Point3D point1 = new Point3D(0, 1, 1);
            Point3D point2 = new Point3D(0, 2, 2);
            string distance =Distance.DistanceMethod(point1, point2);

            Console.WriteLine(distance);
        }
    }
}
