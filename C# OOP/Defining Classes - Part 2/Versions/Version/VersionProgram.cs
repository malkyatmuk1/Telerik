using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Versionattribute;

namespace Defining_Classes___Part_2
{
    [Versionattributee("2.0.2")]
    class Class1
    {

        static void Main(string[] args)
        {
            Type type = typeof(Class1);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (Versionattributee versions in allAttributes)
            {
                Console.WriteLine("The verion is ({0}). ",
                  versions.Version);
            }

        }
    }
}
