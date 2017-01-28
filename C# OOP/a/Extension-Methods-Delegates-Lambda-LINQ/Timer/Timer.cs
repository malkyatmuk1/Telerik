namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Threading;

    class Timer
    {
        public static void Print()
        {
            Console.WriteLine("I'm Stamat and I love repeating Telerik!: Problem #7");
        }
        public delegate void TimerDelegate(); 
               
        public static void RepeatSomeMethod(TimerDelegate method, int seconds, long durationInSeconds)
        {
            long start = 0;
            while (start <= durationInSeconds)
            {
                method();
                Thread.Sleep(seconds * 500);
                start =start+ seconds;
            }

        }
        static void Main(string[] args)
        {
            TimerDelegate d=null;
            d = d+Print;

            RepeatSomeMethod(d,1,10);
        
        }
    }
}
