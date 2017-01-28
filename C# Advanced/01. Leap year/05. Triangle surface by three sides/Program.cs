using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_three_sides
{
    class Program
    {
        class Triangle
        {

      
            public Triangle(double Sidea, double Sideb, double Sidec)
            {
                side1 = Sidea;
                side2 = Sideb;
                side3 = Sidec;
            }
            private double side1 = 0, side2 = 0, side3 = 0;
            
            public double FoundArea(double sidea,double sideb,double sidec)
            {
                double s = (sidea + sideb + sidec) / 2;
                double area = 1;
                area = Math.Sqrt(s * (s - sidea) * (s - sideb) * (s - sidec));

                return area;
            }
        }
        static void Main(string[] args)
        {
            double s1,s2,s3;
            Triangle triangle = new Triangle( s1=double.Parse(Console.ReadLine()),s2= double.Parse(Console.ReadLine()), s3=double.Parse(Console.ReadLine()));

            Console.WriteLine(triangle.FoundArea(s1, s2, s3).ToString("0.00"));
        }
    }
}
