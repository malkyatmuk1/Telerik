namespace Problem_2.Bank_accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Problem_2.Bank_accounts.Class;
    class Testprogram
    {
        static void Main(string[] args)
        {

            Accounts loan = new Loan(Customer.Individuals, 100, 50, new DateTime(2000, 02,11 ));
            Accounts deposit = new Deposit(Customer.Companies, 10000, 50859, new DateTime(2017, 01, 11));
            Accounts mortgage = new Mortgage(Customer.Companies, 10058, 5020, new DateTime(2016, 02, 11));
            Console.WriteLine(loan);
            Console.WriteLine(deposit);
            Console.WriteLine(mortgage);
        }
    }
}
