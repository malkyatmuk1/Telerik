using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles___Part_1
{
    class School
    {
        private List<Classes> classes;
        public List<Classes> Classes 
        {
            get
            {
                return this.classes;
            }
            set 
            {
                this.classes = value;
            }
        }
        public School()
        {
            this.classes = new List<Classes>();
                
        }

        public void AddClass(Classes clas)
        {
            this.classes.Add(clas);
        }
    }
}
