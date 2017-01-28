namespace Defining_Classes___Part_2
{
    using System;
     static class Path
    {
       static Point3D[] points;
       private static  int count=0;
         
       static  Path()
       {
           count++;
           points = new Point3D[10];
       }

        public static  void SaveIn3D(Point3D point)
        {
            points[count] = point;
          
        }

    }

}