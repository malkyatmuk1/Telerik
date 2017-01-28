using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2
{
   
    class Class1
    {
         [Versionattribute("2.0.1")]
        static void Main1(string[] args)
        {
            Type type = typeof(Class1);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (Versionattribute versions in allAttributes)
            {
                Console.WriteLine("This is the verion {0}. ",
                  versions.Version);
            }

        }
    }
}
