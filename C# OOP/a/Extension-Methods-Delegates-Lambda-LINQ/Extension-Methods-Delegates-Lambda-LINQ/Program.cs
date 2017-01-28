namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using StringBuilderExpresion;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intcheta = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            string duma = "tanq";
            Console.WriteLine("Here SubString is in use!: Problem #1");
            
            Console.WriteLine(duma.Substring(1, 2));
            Console.WriteLine();
            Console.WriteLine("Problem #2");
            Console.WriteLine("We sum some integers!");
           Console.WriteLine( intcheta.Sum<int>());
           Console.WriteLine();
           Console.WriteLine("We found whith is the smallest!");
           Console.WriteLine(intcheta.Minus<int>());
           Console.WriteLine();
           Console.WriteLine("We found witch is the biggest!");
           Console.WriteLine(intcheta.Max<int>());
           Console.WriteLine();
           Console.WriteLine("We found avarage value!");
           
           Console.WriteLine(intcheta.Avarage<int>());
           Console.WriteLine();
           Console.WriteLine("We found the product!");
           Console.WriteLine(intcheta.Product<int>());

        }
    }
}
