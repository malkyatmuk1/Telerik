namespace Problem_3.Range_Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Test
    {
        static void Main(string[] args)
        {
            int[] first = { 12, 15, 10, 7 };
            foreach (var item in first)
            {
                try
                {
                    if (item < 1|| item > 100) throw new InvalidRangeException<int>(1, 100);
                    Console.WriteLine("{0} is in the range!",item);
                }
                catch(InvalidRangeException<int> ex)
                {
                    Console.WriteLine(ex.Message);
                }
 
            }
            Console.WriteLine("..........");

            DateTime[] second={new DateTime(2000,11,02),new DateTime(1800,12,01)};
            DateTime start=new DateTime(1980,1,1);
            DateTime end=new DateTime(2013,12,31);
            foreach (var item in second)
            {
                try
                {
                    if (item < start || item > end) throw new InvalidRangeException<DateTime>(start, end);
                    Console.WriteLine("{0} is in the range!", item);
                }
                catch (InvalidRangeException<DateTime> ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
