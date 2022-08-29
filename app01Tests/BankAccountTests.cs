using Microsoft.VisualStudio.TestTools.UnitTesting;
using app01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app01.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void DebitTest()
        {
            // arrange  
            int beginningBalance = 11;
            int debitAmount = 4;
            int expected = 7;
            BankAccount account = new BankAccount(beginningBalance);

            // act  
            account.Debit(debitAmount);

            // assert  
            int actual = account.CurrenceBalance;
            Assert.AreEqual(expected, actual, 0, "Account not debited correctly");
        }
    }
}