using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Defining_Classes___Part_2;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
           GenericList<int> intList= new GenericList<int>(3);
           Console.WriteLine("I added things in the list!");
            intList.Add(1223);
            intList.Add(12);
            intList.Add(122);
            intList.Add(123344);
             Console.WriteLine(intList);

            Console.WriteLine("**********");

            intList.Insert(123,2);
            Console.WriteLine("After Inserting 123 in position 2 count from 0 : \n{0}", intList);

            Console.WriteLine("**********");

            GenericList<string> stringList = new GenericList<string>(3);

            stringList.Add("kola");
            stringList.Add("voda");
            stringList.Add("kilo");
            stringList.Add("far");
            stringList.Add("doda");
            Console.WriteLine("After Adding(and resizing) \n{0}",stringList);

            Console.WriteLine("**********");

            stringList.Insert("az sum", 1);
            Console.WriteLine("After inserting az sum in position 1 count from 0: \n{0}", stringList);

            Console.WriteLine("The word kilo is in index: {0}",stringList.Find("kilo"));
            Console.WriteLine("This is the max element : {0}",stringList.Max());
            Console.WriteLine("This is the min element : {0}", stringList.Min());

            Console.WriteLine("**********");

            stringList.Remove(2);
            Console.WriteLine("After removing element in position 2\n{0}", stringList);

            Console.WriteLine("**********");
            
            
            stringList.Clear();
            Console.WriteLine("After clearing(there is nothing because we clear the list ): {0}  ", stringList);

            
        }
    }
}
