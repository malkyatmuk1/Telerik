using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_surface_by_two_sides_and_an_angle
{
    class Triangle
    {
     
        public double Sidea { get; set; }
        
        public double Sideb { get; set; }
        
        public double Angle { get; set; }

        public Triangle(double sidea,double sideb, double angle)
        {
            Sidea=sidea;
            Sideb = sideb;
            Angle=angle;

        }
        public double FoundArea(double sidea,double sideb,double angle)
        {
            double area;
            area=(sidea*sideb*(Math.Sin(angle*Math.PI/180)))/2;
            
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            double sidea=double.Parse(Console.ReadLine());
            double sideb = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(sidea,sideb, angle);
            triangle.Sidea=sidea;
            triangle.Sideb = sideb;
            triangle.Angle = angle;

            Console.WriteLine(triangle.FoundArea(sidea, sideb, angle).ToString("0.00"));

        }
    }
}
