using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCollectionTest.OOP
{
    using PracticeCollection.OOP;
    public static class MockBankAccountTests
    {
        [Test]
        public static void Tests()
        {
            var account = new MockBankAccount("<name>", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        }
    }
}
