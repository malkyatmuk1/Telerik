using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animal_hierarchy.Class
{
    class Tomcat:Cats
    {
        public Tomcat(string name,int age):base(name,age)
        {
           this.Genderer = Gender.Male;
        }
    }
}
