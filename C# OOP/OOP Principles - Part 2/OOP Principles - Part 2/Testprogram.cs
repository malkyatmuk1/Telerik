namespace OOP_Principles___Part_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OOP_Principles___Part_2.Class;
    class Testprogram
    {
        static void Main(string[] args)
        {

            Shape[] shapes = { new  Square(12),new  Rectangle(12,2),new Triangle(3,2) };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
