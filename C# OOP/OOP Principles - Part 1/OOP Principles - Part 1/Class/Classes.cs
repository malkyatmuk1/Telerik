using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles___Part_1
{
    class Classes : IComment
    {
        private string uniqueTextIdentifier;
        private List<Teachers> teachers;
        public string Comment { get; set; }
        public string UniqueTextIdentifier
        { 
            get
            {
                return this.uniqueTextIdentifier;
            } 
            set
            {
                if (value == null) throw new Exception("The unique text cannot be null!");
                this.uniqueTextIdentifier = value;
            } 
        }
        public List<Teachers> Teachers {
            get 
            {
                return this.teachers;
            }
            set 
            {
                this.teachers = value;
            }
        }
        public Classes(string uniqueTextIdentifier, string comment)
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
            this.teachers = new List<Teachers>();
            this.Comment = comment;
        }
        public Classes(string uniqueTextIdentifier)
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
            this.teachers = new List<Teachers>();
        }
        public void AddTeacher(Teachers teacher)
        {
            this.teachers.Add(teacher);
        }
    }
}
