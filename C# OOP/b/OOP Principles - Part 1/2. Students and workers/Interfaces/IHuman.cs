using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHuman1
{
    interface IHuman 
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string ToString();

    }
}
