namespace Defining_Classes___Part_2
{
    using System;
    using Path1;
    using Point3D1;
    using Distance1;
    class Program
    {
        static void Main(string[] args)
        {

            string textFileOne = @"../../neshto1.txt";
            string textFileTwo = @"../../neshto2.txt";
            
            


            Point3D point1 = new Point3D(0, 1, 1);
            Point3D point2 = new Point3D(0, 2, 2);
            string distance =Distance.DistanceMethod(point1, point2);
            
            PathStorage.ReadFromFile(textFileOne);
            PathStorage.Write(point1, textFileTwo);
            PathStorage.Write(point2, textFileTwo);
            Console.WriteLine(distance);
        }
    }
}
