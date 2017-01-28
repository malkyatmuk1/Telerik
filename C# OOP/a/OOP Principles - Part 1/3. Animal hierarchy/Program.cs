using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Animal_hierarchy.Class;

namespace _3.Animal_hierarchy
{
    class Program
    {
        public static string Average(Animal[] an)
        {
            var average = an.Average(x => x.Age);
            return average.ToString("0.000");
        }
        static void Main(string[] args)
        {
            Cats[] cat = new Cats[]
            {
                new Tomcat("Ivan",11),
                new Kitten("Ivanka",12),
               
            };
            Dog[] dog = new Dog[]
            {
                new Dog("Kuchence",15,Gender.Female),
                new Dog("Kuche",19,Gender.Male)
            };
            Frog[] frog = new Frog[]{
            new Frog("Jabka",2,Gender.Female),
            new Frog("Jabok",15,Gender.Male)
            };
            Console.WriteLine(Average(cat));
            foreach (var item in cat)
            {
                Console.Write(item.ToString() + " .");
                item.Sound();
            }
            Console.WriteLine();
            Console.WriteLine(Average(dog));
            foreach (var item in dog)
            {
                Console.Write(item.ToString() + " .");
                item.Sound();
            }
            Console.WriteLine();
            Console.WriteLine(Average(frog));
            foreach (var item in frog)
            {
                Console.Write(item.ToString()+" .");
                item.Sound();
            }

        }
    }
}
