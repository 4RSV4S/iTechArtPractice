using System;
using NUnit.Framework;
using Pract11.Utilities;

namespace Pract11.UnitTests
{
    [TestFixture]
    [Category("QuickRunning")]
    public class AccountTests
    {
        private Account account;

        [SetUp]
        public void Setup()
        {
            account = new Account(100, 1);
        }
        [TearDown]
        public void TearDown()
        {
            account = null;
        }

        [Test]
        public void GetBalance_InitializedWithBalanceAndId_ReturnCorrectBalance()
        {
            Assert.AreEqual(account.GetBalance(), account.balance);
        }

        [Test]
        public void GetAccountId_InitializedWithBalanceAndId_ReturnCorrectId()
        {
            Assert.AreEqual(account.GetAccountId(), account.id);
        }

        [Test, Order(1)]
        public void Add_AddingFunds_BalanceChanging()
        {
            account.Add(50);
            Assert.Multiple(() =>
            {
                Assert.Greater(account.balance, 100);
                Assert.AreNotEqual(100, account.balance);
            });
        } 

        [Test, Order(3)]
        public void Add_AddingFunds_BalanceUpdates()
        {
            account.Add(50);

            Assert.AreEqual(150, account.GetBalance());
        }

        [Test, Order(5)]
        public void Add_NegativeFundsAdding_ExceptionThrows()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Add(-500));
        }

        [Test, Order(2)]
        public void Withdraw_WithdrawFunds_BalanceChanging()
        {
            account.Withdraw(50);
            Assert.Multiple(() =>
            {
                Assert.Less(account.balance, 100);
                Assert.AreNotEqual(100, account.balance);
            });
        }

        [Test, Order(4)]
        public void Withdraw_WithdrawFunds_BalanceUpdates()
        {
            account.Withdraw(50);
            Assert.AreEqual(50, account.balance);
        }

        [Test, Order(6)]
        public void Withdraw_NegativeFundsWithdraw_ExceptionThrows()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(-50));
        }

        [Test, Order(7)]
        public void Withdraw_MoreThanBalanceWithdraw_ExceptionThrows()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(200));
        }

        [Test]
        public void TransferFundsTo_TransferingFunds_BalanceUpdatesBothAccounts()
        {
            var anotherAccount = new Account(0, 2);

            account.TransferFundsTo(anotherAccount, 50);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(50, account.balance);
                Assert.AreEqual(50, anotherAccount.balance);
            });
        }

        [Test]
        public void TransferFundsTo_TransferToNullAccount_ExceptionThrows()
        {
            Assert.Throws<ArgumentNullException>(() => account.TransferFundsTo(null, 100));
        }

        [Test]
        public void ToLogTransfer_TransferingFunds_TranferLogged()
        {
            var anotherAccount = new Account(0, 2);
            account.TransferFundsTo(anotherAccount, 50);

            Assert.Contains($"50 transferred to account {anotherAccount.id}", account.TransferLog);
        }

        [Test]
        public void IsInitialized_InitializedWithBalanceAndId_IsInitializedIsTrue()
        {
            var anotherAccount = new Account(100, 1);

            Assert.True(anotherAccount.isInitialized);
        }

        [Test]
        public void IsInitialized_InitializedWithNoParams_IsInitializedIsFalse()
        {
            var anotherAccount = new Account();

            Assert.False(anotherAccount.isInitialized);
        }

        [Test]
        [Ignore("Ignore a test")]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}