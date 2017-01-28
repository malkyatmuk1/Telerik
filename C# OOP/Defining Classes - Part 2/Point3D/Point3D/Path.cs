namespace Path1
{
    using System;
    using Point3D1;
   
     static class MyPath
    {
       static Point3D[] points;
       private static  int count=0;
         
       static  MyPath()
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