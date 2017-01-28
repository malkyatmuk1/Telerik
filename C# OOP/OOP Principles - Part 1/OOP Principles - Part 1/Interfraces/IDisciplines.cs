using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles___Part_1
{
    interface IDisciplines
    {
       string Name { get; set; }
       string Comment { get; set; }
       int NumberOfLectures { get; set; }
       int NumberOfExercises { get; set; }
    }
}
