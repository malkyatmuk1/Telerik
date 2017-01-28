using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sound1;
namespace _3.Animal_hierarchy.Class
{
    class Animal: ISound
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Genderer { get; set; }
        public Animal(string name,int age,Gender gender)
        {
            this.Genderer = gender;
            this.Name = name;
            this.Age = age;
                
        }
        public Animal(string name, int age)
        {
           
            this.Name = name;
            this.Age = age;

        }
                public override string ToString()
        {
            StringBuilder stroitel = new StringBuilder();
            stroitel.Append(string.Format("My name is {0}, my age is {1}, my gender is {2}",this.Name,this.Age,this.Genderer ));
            return stroitel.ToString();
        }
        public virtual  void Sound()
        {
            Console.WriteLine("hahah that is my sound!");
            
        }
    }
}
