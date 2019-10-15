using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class Account
    {
        public string AccountNo;
        public string Name;
        public double Balance;
        public double Amount;
        public void Withdraw(Account account)
        {
            Balance -= account.Amount;

        }

        public void Deposit(Account account)
        {
            Balance += account.Amount;
        }

        public string Report()
        {
            string message = Name +",your account Number: "+AccountNo +"and  its Balance "+Balance+"Taka";
            return message;
        }
    }

}
