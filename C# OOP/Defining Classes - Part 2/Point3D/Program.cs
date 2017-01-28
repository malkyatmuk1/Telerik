namespace Defining_Classes___Part_2
{
    using System;
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
