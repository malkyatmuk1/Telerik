namespace Grouped_by_GroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;
    class ProgramGrouped
    {
        public static void GroupNumber(List<Student> students)
        {
            var stu = from student in students
                      where student.GroupNumber != 0
                      orderby student.FirstName
                      group student by student.GroupNumber into newGroup
                      orderby newGroup.Key
                      select newGroup;
                   foreach (var item in stu)
            {
                Console.WriteLine("Group Number: {0}",item.Key);
                foreach (var student in item)
                {
                    Console.WriteLine("\t{0}, {1}", student.LastName, student.FirstName);
                }
            }

        }


       static void Main(string[] args)
        {
            List<Student> students = new List<Student>{
                    new Student("Ivan", "Ivanov", "23340606","0299999555", "ivan@abv.bg",2,   3, 3, 3, 5, 4, 1, 2),
                    new Student("Puncho", "Angelov","23340606","+359212345123", "a@abv.bg",1,   2, 1, 1, 6, 1),
                    new Student("Zancho", "Papagalov","233400606","+359123451232", "a@abv.bg",3,   2, 1, 1, 1, 1,2),
                    new Student("Gunchoho", "Angelov","233400606","+359212345123", "a@ab.bg",2,   2, 1, 1, 1, 1)
                    
            };
            Console.WriteLine("Group by LINQ: Problem #18");
            GroupNumber(students);
            Console.WriteLine();
            Console.WriteLine("Group by extension method: Problem #19");
            students.GroupName1();
        }
    }
}
