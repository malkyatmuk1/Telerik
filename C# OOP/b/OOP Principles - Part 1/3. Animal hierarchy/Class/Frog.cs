using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sound1;

namespace _3.Animal_hierarchy.Class
{
    class Frog : Animal, ISound
    {
         public Frog(string name,int age,Gender gender)
             :base(name,age,gender)
        {

        }
        public virtual void Sound()
        {
            Console.WriteLine("The sound comes from frog!");
             
        }
    }
}
