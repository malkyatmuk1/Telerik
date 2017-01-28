using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles___Part_1
{
    class Students: People,IPeople,IComment
    {
        private int count=0;
       
        public int Number { get; set; }
        public string Comment { get; set; }
        public Students(string name):base(name)
        {
           
            this.Number =UniqueClassNumber();
        }
        public Students(string name,string comment):base(name)
        {
            this.Comment = comment;
        }
        private int UniqueClassNumber()
        {
            count++;
            return count;
        }
    }
}
