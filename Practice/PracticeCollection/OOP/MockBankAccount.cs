using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCollection.OOPMockBankAcc
{
    public class MockBankAccount(string name, decimal initialBalance)
    {
        private static int s_accountNumberSeed = 1234567890;
        public string Number { get; } = s_accountNumberSeed.ToString();
        public string Owner { get; set; } = name;
        public decimal Balance { get; } = initialBalance;

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
