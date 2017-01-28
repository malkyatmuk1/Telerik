namespace Problem_2.Bank_accounts.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Problem_2.Bank_accounts.Interface;
    class Mortgage:Accounts,IDeposit
    {
        public Mortgage(Customer ct, double balance, int rate, DateTime start)
            : base(ct,balance,rate,start)
        {

        }

        public override double Interest()
        {
            if (base.Cust==Customer.Companies && base.Months<12) return base.Months * base.InterestRate/2;
            if (base.Cust == Customer.Individuals && base.Months < 6) return 0;
            return base.Months * base.InterestRate;
        }
    }
}
