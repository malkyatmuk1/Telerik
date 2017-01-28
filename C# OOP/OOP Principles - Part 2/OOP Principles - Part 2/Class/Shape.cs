namespace OOP_Principles___Part_2.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
   public abstract class Shape
    {
       private double width;
       private double height;
       public Shape(double width,double height)
       {
           this.Width = width;
           this.Height = height;

       }
       public double Width {
           get
           {
               return this.width;
           }

           set {
               if (value <= 0) throw new Exception("The width cannot be negativ or null!");
               this.width = value;
           }
       }
       public double Height {
           get
           {
               return this.height;
           }

           set {
               if (value <= 0) throw new Exception("The height cannot be negativ or null!");
               this.height = value;
           }
       }
       public abstract double CalculateSurface();
       

    }
}
