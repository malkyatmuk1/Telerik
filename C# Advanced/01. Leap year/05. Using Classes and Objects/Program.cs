using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Using_Classes_and_Objects
{
    
    public class Years
    {


        private string isleap = "Common";
    
       public Years(int year)
       {
           Year = year;
       }
       public int Year { get; set; }

   
        public  string Isleap(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) isleap = "Leap";
            return isleap;
        }
    }
    class Program
    {
       static void Main()
        {
            int years;
            Years year=new Years(years=int.Parse(Console.ReadLine()));
            
            
            Console.WriteLine(year.Isleap(years));
        
        }
       
    }
}
