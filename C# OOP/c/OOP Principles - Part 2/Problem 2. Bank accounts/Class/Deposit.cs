namespace Problem_2.Bank_accounts.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Problem_2.Bank_accounts.Interface;
    class Deposit:Accounts, IWithDraw
    {
        public Deposit(Customer ct, double balance, int rate, DateTime start)
            : base(ct,balance,rate,start)
        {

        }

        public override double Interest()
        {
            if (base.Balance > 0 && base.Balance < 1000) return 0;
            return base.Months * base.InterestRate;
        }

        public void WithDraw(int sum)
        {
            if (sum<= 0)
            {
                throw new Exception("The sum cannot be a negative or a zero!");
            }
            this.Balance = this.Balance - sum;
        }
    }
}
