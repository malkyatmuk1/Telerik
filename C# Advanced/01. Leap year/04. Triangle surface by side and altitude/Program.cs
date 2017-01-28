using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class Triangle
    {
        int sidea;
        int sideb;
        int sidec;
        int altitutea;
        int altituteb;
        int altitutec;
        public double Area(double heigth, double side)
        {
            double area = 1;
            area = area * heigth * side / 2;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double heigth = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle();
            Console.WriteLine(triangle.Area(heigth, side).ToString("0.00"));
        }
    }
}
