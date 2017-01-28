namespace Students_group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;
    using Students_group;
    class Program
    {
        public static void PrintStudents(IEnumerable<Student> arr,int index)
        {
            foreach (var student in arr)
            {
                Console.Write(student+ " ");
                if (index == 3) { Console.Write(student.Tel); Console.WriteLine(); }
                else if (index == 2) Console.WriteLine(student.Email);
                else if (index == 1) Console.WriteLine(student.GroupNumber);
                else if (index == 4) {

                    foreach (var item in student.Marks)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                
            }
        }
        public static void StudentGroups(List<Student> students)
        {
            var studentonly2 = from stundent in students
                               where stundent.GroupNumber == 2
                               orderby stundent.FirstName
                               select stundent;
            PrintStudents(studentonly2,1);
        }
        
        public static void ExtractStudentsByEmail(List<Student> students,int index)
        {
            
            if (index == 1)
            {
                var studentemail = from student in students
                                   where student.Email.Contains("abv.bg")
                                   orderby student.FirstName
                                   select student;
                PrintStudents(studentemail,2);

            }
            else
            {
               var  studentemail = students.Where(st => st.Email.Substring(st.Email.IndexOf('@') + 1) == "abv.bg");
               PrintStudents(studentemail,2);
            }
            
        }
        public static void ExtractStudentsByPhone(List<Student> students)
        {
            var studenttel = from student in students
                               where student.Tel.Contains("02")|| student.Tel.Contains("+3592")
                               orderby student.FirstName
                               select student;
            PrintStudents(studenttel,3);
           
        }

        public static void ExtractStudentsByMarks (List<Student> students)
        {

            var studentmarks = from student in students
                               where student.Marks.Contains(6)
                               orderby student.FirstName
                               select new { FullName = student.FirstName + " " + student.LastName, Marks = string.Join(", ", student.Marks) };
            foreach (var item in studentmarks)
            {
                
                Console.WriteLine(item + ",");
            }

           


        }
        public static void ExtractMarks(List<Student> students)
        {
            var studentfn = students.Where(st => st.FA[5] == '0' && st.FA[6] == '6');
            foreach (var item in studentfn)
            {
                 foreach (var itemi in item.Marks)
                    {
                        Console.Write(itemi + " ");
                    }
                 Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>{
                    new Student("Ivan", "Ivanov", "23340606","0299999555", "ivan@abv.bg",2,   3, 3, 3, 5, 4, 1, 2),
                    new Student("Puncho", "Angelov","23340606","+359212345123", "a@abv.bg",1,   2, 1, 1, 6, 1),
                    new Student("Zancho", "Papagalov","233400606","+359123451232", "a@abv.bg",3,   2, 1, 1, 1, 1,2),
                    new Student("Gunchoho", "Angelov","233400606","+359212345123", "a@ab.bg",2,   2, 1, 1, 6, 1)
                    
            };
            Console.WriteLine("First way to print students: Problem #9");
            StudentGroups(students);

            Console.WriteLine();
            Console.WriteLine("Second way to print students: Problem #10");
           students.StudentGroups1();

           Console.WriteLine();
           Console.WriteLine("First way to print students: Problem #11");
           ExtractStudentsByEmail(students,1);

           Console.WriteLine();
           Console.WriteLine("Second way to print students: Problem #11");
           ExtractStudentsByEmail(students, 2);

           Console.WriteLine();
           Console.WriteLine("Students who are from Sofiq(with tel.numbers from Sofiq): Problem #12");
           ExtractStudentsByPhone(students);
            
           Console.WriteLine();
           Console.WriteLine("Students who have Exelent mark: Problem #13");
           ExtractStudentsByMarks(students);

           Console.WriteLine();
           Console.WriteLine("Students who have exactly 2 poor marks: Problem #14");
           students.StudentWith2Marks();

           Console.WriteLine();
           Console.WriteLine("Students that enrolled in 2006.: Problem #15");
           ExtractMarks(students);
        }
    }
}
