namespace Defining_Classes___Part_2
{
    using System;
    using System.Text;
    using System.IO;
     public static class PathStorage
    {
        
         public static void ReadFormFile()
         {
             var stream=new StreamReader(@"..\..\neshto.txt");

             using(stream) 
             {  string fileContent="";

                 while(fileContent!=null){
                 fileContent=stream.ReadLine();
                  string[] cordinates=fileContent.Split(' ');
                  Point3D point = new Point3D(Convert.ToInt32(cordinates[0]), Convert.ToInt32(cordinates[2]), Convert.ToInt32(cordinates[3]));
                 Path.SaveIn3D(point);

                 }

             }
         }
         public static void Write(Point3D point) {
         
             var fileName=@"..\..\neshto.txt";
             var appendToFile=true;
             var encoding=Encoding.UTF8;
             var writer = new StreamWriter(fileName, appendToFile, encoding);
         using(writer)
             {

                 writer.WriteLine(point);
             }
         }


    }
}
