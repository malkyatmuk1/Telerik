using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animal_hierarchy.Class
{
    class Kitten:Cats
    {
        public Kitten(string name,int age):base(name,age)
        {
            this.Genderer = Gender.Female;
        }
    }
}
