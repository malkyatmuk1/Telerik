using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles___Part_1
{
    class People : IPeople
    {
        private string name;
        public string Name 
        {
            get
            {
                return this.name;
            } 
            set
            {
                if (value  == null) throw new NullReferenceException("The name cannot be nothing!");
                this.name = value;

            } 
        }
        public People(string name)
        {
            this.Name = name;
        }

    }
}
