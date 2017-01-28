using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Defining_Classes___Part_2
{
     public static class PathStorage
    {
         public PathStorage()
         {
            
         }
         public static void ReadFormFile()
         {
             var stream=new StreamReader(@"..\..\neshto.txt");

             using(stream) 
             {  string fileContent="";

                 while(fileContent!=null){
                 fileContent=stream.ReadLine();
                  string[] cordinates=fileContent.Split(' ');
                  Point3D point = new Point3D(Convert.ToInt32(cordinates[0]), Convert.ToInt32(cordinates[2]), Convert.ToInt32(cordinates[3]));
                  SaveInFile(point);

                 }

             }
         }
         public static void SaveInFile(Point3D point) {
         
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
