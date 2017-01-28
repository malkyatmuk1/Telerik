using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHuman1;

namespace _2.Students_and_workers
{
    class Student: Human, IHuman
    {
        private int grade;
        public int Grade {
            get 
            {
                return this.grade;
            }
            set
            {
                if (value <= 0) throw new Exception("The grade cannot be negativ or null");
                this.grade = value;
            }
        }
        public Student(string firstName, string lastName,int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
        public override string ToString()
        {
            StringBuilder stroitel=new StringBuilder();
            stroitel.Append(string.Format("{0} and my grade is {1}",base.ToString(),this.Grade));
            return stroitel.ToString();
        }

    }
}
