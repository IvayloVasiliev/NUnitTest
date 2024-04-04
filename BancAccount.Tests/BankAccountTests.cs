using NUnit.Framework;

namespace BankAcount.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _acc;

        [SetUp]
        public void TestInit()

        {
            _acc = new BankAccount(1000);
        }








        [Test]
        public void AcountDepositWithPositiveValue()
        {
            _acc.Deposit(1000);
            Assert.AreEqual(2000, _acc.Amount);
        }

        [Test]
        public void AcountInitializeWithZero()
        {
            _acc = new BankAccount(0);
            _acc.Deposit(0);
            Assert.That(_acc.Amount, Is.EqualTo(0));
        }

        [Test]
        public void AcountWithdrawToNegativeValue()
        {
            Assert.That(() => { _acc.Withdraw(1001); },
                Throws.ArgumentException);          
        }

        [Test]
        public void AcountWithdrawWithThousand()
        {
            _acc = new BankAccount(1000 + (1000 * 0.02m));
            _acc.Withdraw(1000);
            Assert.AreEqual(0, _acc.Amount);
        }

        [Test]
        public void AcountWithdrawWithLessThanThousand()
        {
            _acc = new BankAccount(500 + (500 * 0.05m));
            _acc.Withdraw(500);
            Assert.AreEqual(0, _acc.Amount);
        }
    }
}
