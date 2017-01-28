namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   
   public class Program
    {
        public static void PrintStudents(IEnumerable<Student> arr)
        {
            foreach (var student in arr)
            {
                Console.WriteLine(student);
            }
        }
        public static void FirstBeforeLast(List<Student> students)
        {
              var str=students.Where(st => string.Compare(st.FirstName,st.LastName)<0).OrderBy(st =>st.FirstName);
              PrintStudents(str);
        }   
        public static void AgeRange(List<Student> students)
        {
            var str = students.Where(student => student.Age >= 18 && student.Age <= 24);
            PrintStudents(str);
        }
            
        public static void OrderStudents(List<Student> students)
        {
            var str = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);
            PrintStudents(str);
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> { new Student("Ivan", "Ivanov", 49), new Student("Angel", "Ivanov", 16), new Student("Zancho", "Arnoto", 69), new Student("Zancho", "Zarnoto", 18) };
            Console.WriteLine("Students with First name before last name: Problem #3");
            FirstBeforeLast(students);
            Console.WriteLine();
            Console.WriteLine("Students with age >=18 or <=24: Problem #4");
            AgeRange(students); 
            Console.WriteLine();
            Console.WriteLine("Ordered students by their Names !: Problem #5");
            OrderStudents(students);
        }
    }
}
