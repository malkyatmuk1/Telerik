using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles___Part_1
{
    class Teachers: People,IPeople,IComment
    {

        private List<Disciplines> disciplines;

        public List<Disciplines> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }
        
        public string Comment { get; set; }
        public Teachers(string name):base(name)
        {
            this.disciplines = new List<Disciplines>();
            this.Name = name;
        }
        public Teachers(string name,string comment):this(name)
        {
            this.disciplines = new List<Disciplines>();
            this.Comment = comment;
        }
        public void AddDiscipline(Disciplines discipline)
        {
            this.disciplines.Add(discipline);
        }

    }
}
