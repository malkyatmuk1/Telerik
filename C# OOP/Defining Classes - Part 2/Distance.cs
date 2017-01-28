using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2
{
    public static class Distance
    {
         public static string DistanceMethod(Point3D point1,Point3D point2)
        {
            double distance ;
            distance = Math.Sqrt(Math.Pow((point1.X - point2.X), 2) + Math.Pow((point1.Y - point2.Y), 2) + Math.Pow((point1.Z - point2.Z), 2));
            return distance.ToString("0.000");
        }
    }
}
