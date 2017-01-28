namespace Grouped_by_GroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;
    public static class ExpresionMetodexpresions
    {
        public static void GroupName1(this List<Student> students)
        {
            var stu = from student in students
                      where student.GroupNumber != 0
                      orderby student.FirstName
                      group student by student.GroupNumber into newGroup 
                      orderby newGroup.Key
                      select newGroup;
            foreach (var item in stu)
            {
                Console.WriteLine("Group Number: {0}", item.Key);
                foreach (var student in item)
                {
                    Console.WriteLine("\t{0}, {1}", student.LastName, student.FirstName);
                }
            }
        }
    }
}
