namespace Problem_2.Bank_accounts.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Problem_2.Bank_accounts.Interface;
    class Loan:Accounts,IDeposit
    {
        public Loan(Customer ct, double balance, int rate, DateTime start)
            : base(ct,balance,rate,start)
        {

        }


        public override double Interest()
        {
            if (base.Cust == Customer.Individuals && base.Months < 3) return 0;
            if (base.Cust == Customer.Companies && base.Months < 2) return 0;
            return base.Months * base.InterestRate;
        }
    }
}
