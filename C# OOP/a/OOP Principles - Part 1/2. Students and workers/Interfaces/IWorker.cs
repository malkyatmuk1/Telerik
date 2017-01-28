using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    interface IWorker
    {
        int WeekSalary { get; set; }
        int WorkHoursPerDay { get; set; }
        double MoneyPerHour();
        string ToString();
    }
}
