namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
   public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FA { get; private set; }
        public string Tel { get; private set; }
        public string Email { get;private set; }
        public List<double> Marks { get;private set; }
        public int GroupNumber { get;private set; }
        public int Age { get;private set; }
        public Student(string firstname,string lastName,int age)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
            this.Age = age;

        }
        public Student(string firstName,string lastName,string fa,string tel,string email,int groupnumber ,params double[] marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FA = fa;
            this.Tel = tel;
            this.Email = email;
            this.Marks = new List<double>(marks); 
            this.GroupNumber = groupnumber;
            
        }

        public override string ToString()
        {
            StringBuilder student = new StringBuilder();
            student = student.Append(FirstName).Append(" ").Append(LastName).Append(" ");
            if (Age != 0) student.Append(Age);
            return student.ToString();

        }



    }
}
