using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Students_and_workers
{
  public abstract class Human
    {
       private string firstName;
       private string lastName;
       public Human(string firstName,string secondName)
       {
           this.FirstName = firstName;
           this.LastName = secondName;
            
       }
         public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null) throw new Exception("The first name cannot be nothing!");
                this.firstName = value;
            }
        
        }
         public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value== null) throw new Exception("The last name cannot be nothing!");
                this.lastName = value;
            }

        }
       public override string ToString()
        {
            StringBuilder stroitel=new StringBuilder();
            stroitel.Append(string.Format("My name is {0} {1}",this.FirstName,this.LastName));
            return stroitel.ToString();
        }
        
    }
}
