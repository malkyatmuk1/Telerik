using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sound1;
namespace _3.Animal_hierarchy.Class
{
    class Cats : Animal, ISound
    {
        public Cats(string name,int age):base(name,age)
        {

        }
        public virtual void Sound()
        {
            Console.WriteLine("The sound comes from cats!");

        }
    }
}
