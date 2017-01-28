namespace Problem_2.Bank_accounts.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Problem_2.Bank_accounts.Interface;
   abstract class  Accounts: IDeposit
    {

        public Customer Cust  { get; set; }
        public double Balance { get; set; }
        public int InterestRate { get; set;}
      
        public DateTime Start { get; set; }
        public int Months { get { return (DateTime.Now.Year * 12 + DateTime.Now.Month) - (this.Start.Year * 12 + this.Start.Month); }  }
        public Accounts(Customer ct,double balance,int rate,DateTime start)
        {
            this.Cust=ct;
            this.Balance=balance;
            this.InterestRate =rate;
            this.Start = start;
        }

       
        public abstract double Interest();

        public void MakeDeposit(int sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentException("The sum cannot be a negative or a zero !");            
            }
            this.Balance = this.Balance + sum;
        }
       public override string ToString()
       {
            StringBuilder stroitel=new StringBuilder();
            stroitel.Append(string.Format("The interest is: {0}, the balance is: {1}!",Interest(),this.Balance));
            return stroitel.ToString();
       }

    }
}
