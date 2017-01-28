namespace Defining_Classes___Part_2
{
    using System;
    using System.Text;
    using System.IO;
    using Point3D1;
    using Path1;
    
     public static class PathStorage
    {
         
       
         public static void ReadFromFile(string stream)
         {
      
            var   stream1=new StreamReader(stream);
            string line = stream1.ReadLine();
             using(stream1) 
             {  

                  while(line!=null){
                     
                     
                      string[] cordinates=line.Split(' ');
                      Point3D point = new Point3D(Convert.ToInt32(cordinates[0]), Convert.ToInt32(cordinates[1]), Convert.ToInt32(cordinates[2]));
                      Write(point,@"..\..\neshto2.txt");
                      MyPath.SaveIn3D(point);
                      line = stream1.ReadLine();
                 }

             }
         }
         public static void Write(Point3D point,string filename) {

             var fileName = filename;
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
