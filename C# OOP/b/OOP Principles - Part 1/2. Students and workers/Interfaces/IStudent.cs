using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    interface IStudent
    {
         int Grade { get; set; }
         string ToString();
    }
}
