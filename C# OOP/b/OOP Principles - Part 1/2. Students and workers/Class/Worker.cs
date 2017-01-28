using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHuman1;

namespace _2.Students_and_workers
{
    class Worker:Human,IHuman
    {
        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }
        public Worker(string firstName,string lastName,int salary,int hours)
            :base(firstName,lastName)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = hours;
        }
        public double MoneyPerHour()
        {
            double money=0;
            money = this.WeekSalary / (this.WorkHoursPerDay * 5);
            return money;
        }
        public override string ToString()
        {
            StringBuilder stroitel = new StringBuilder();
            stroitel.Append(string.Format("{0} and my week salary is {1} and my working hours per day are {2}", base.ToString(), this.WeekSalary,this.WorkHoursPerDay));
            return stroitel.ToString();
        }
    }
}
