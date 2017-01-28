namespace Students_group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;

    public static class ExpresionMetodexpresions
    {
        public static void StudentGroups1(this List<Student> students)
        {
            var studentonly2 = from stundent in students
                               where stundent.GroupNumber == 2
                               orderby stundent.FirstName
                               select stundent;
            foreach (var student in studentonly2)
            {
                Console.WriteLine(student+" "+student.GroupNumber);
            }
          
        }
        public static void StudentWith2Marks(this List<Student> students)
        {
            var studentonly2 = students.Where(st => st.Marks.Count(mark => mark - 2 == 0) == 2);
            foreach (var student in studentonly2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
