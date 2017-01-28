using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles___Part_1
{
    class Disciplines: IDisciplines,IComment
    {
        private string name;
        private string comment;
        private int numberOfLectures;
        private int numberOfExercises;
        public string Name { 
            get
            {
                return this.name;
            }
            set 
            {
                this.name = value;
            }
        }
        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0) throw new Exception("You cannot set negativ value of number of lectures!");
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0) throw new Exception("You cannot set negativ value of number of exercises!");
                this.numberOfExercises = value;
            }
        }
        public Disciplines(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLectures = numberOfLectures;
        }
    
        public Disciplines(string name, int numberOfLectures, int numberOfExercises,string comment):this(name,numberOfLectures,numberOfExercises)
        {
            this.Comment = comment;
        }
    }
}
