using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.Students_and_workers.Interfaces;

namespace _2.Students_and_workers
{
    class Program
    {
        public static void PrintHuman(IEnumerable<Human> arr)
        {
            foreach (var human in arr)
            {
                Console.WriteLine(human.ToString());
                
            }

        }
      
        public static void OrderedStudents(List<Student> students)
        {
            var studentgrade = from student in students
                               orderby student.Grade
                               select student;
            PrintHuman(studentgrade);
        }
        public static void OrderedWorkers(List<Worker> workers)
        {
            var workerss = from worker in workers
                               orderby worker.MoneyPerHour() descending
                               select worker;
            PrintHuman(workerss);
        }
        public static void OrderedBoth(List<Human> humans)
        {
            var humanss = from human in humans
                           orderby human.FirstName, human.LastName
                           select human;
            PrintHuman(humanss);
        }
        

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>{
             new Student("Peter","Ivanov",9),
             new Student("Yovko","Ivanov",11),
            new Student("Stoqncho","Stoqnov",5),
            new Student("Dragancho","Draganov",4),
            new Student("Petkancho","Petkanov",12),
            new Student("Stoilcho","Stoilov",10),
            new Student("Dragomircho","Dragomirov",6),
            new Student("Ivaylo","Ivailov",7),
            new Student("Dido","Didov",2)
            };
            List<Worker> worker = new List<Worker>{
                new Worker ("Peter2","Ivanov",100,8),
             new Worker("Yovko2","Ivanov",300,10),
            new Worker("Stoqncho2","Stoqnov",350,1),
            new Worker("Dragancho2","Draganov",375,8),
            new Worker("Petkancho2","Petkanov",125,6),
            new Worker("Stoilcho2","Stoilov",650,11),
            new Worker("Dragomircho2","Dragomirov",101,4),
            new Worker("Ivaylo2","Ivailov",400,6),
            new Worker("Dido2","Didov",60,3)
            };
            var mergedList = new List<Human>();
            mergedList.AddRange(students);
            mergedList.AddRange(worker);
            OrderedStudents(students);
            Console.WriteLine();
            OrderedWorkers(worker);
            Console.WriteLine();
            OrderedBoth(mergedList);
        }
    }
}
