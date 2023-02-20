using BankingSystem;
using NUnit.Framework;
using System;

namespace BankingSystemTesting
{
    public class Tests
    {


        [Test]
        public void DepositShouldIncreaseBalance()
        {
            //Arrange
            int id = 123;
            decimal amount = 500;
            BankAccount bankAccount = new BankAccount(id,amount);
            decimal amountDeposit = 100;

            //Act
            bankAccount.Deposit(amountDeposit);

            //Assert
            Assert.AreEqual(amountDeposit+amount, bankAccount.Balance);
        }
        [Test]
        public void AccountInicializeWithPositiveValue()
        {
            //Arrange

            //Act
            BankAccount bankAccount = new BankAccount(123, 2000m);

            //Assert
            Assert.AreEqual(2000m, bankAccount.Balance);
        }
        [Test]
        public void NegativeAmountShouldThrowInvalidOperationExeptionsWithMessage()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount(123);
            decimal amountDeposit = -100;

            //Act

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => bankAccount.Deposit(amountDeposit));
            Assert.AreEqual(ex.Message, "Negative amount");
        }
        [Test]
        public void ConstructorShouldSetZeroBalance()
        {
            //Arrange
            int id = 123;
            //Act
            BankAccount account = new BankAccount(id);

            //Assert
            Assert.AreEqual(0, account.Balance);


        }
        [Test]
        public void IDTest()
        {
            //Arrange
            int id = 123;
            //Act
            BankAccount account = new BankAccount(id);

            //Assert
            Assert.AreEqual(0, id, account.Id);

        }

        [TestCase(123,500)]
        [TestCase(123, 7896)]
        [TestCase(123, 0)]
        public void ConstructorShouldSetBalanceCorrecty(int id , decimal amount)
        {
            //Arrange&Act
            BankAccount bankAccount = new BankAccount(id, amount);
            
            //Assert
            Assert.AreEqual(amount , bankAccount.Balance);
        }
        [Test]
        public void  BalanceShouldThrowArgumentExeptionWhenBalanceIsNegative()
        {
            //Arrange
            int id = 123;
            decimal amount = -100.123m;
            string message = "Negative amount";

            //Act&
            var ex = Assert.Throws<ArgumentException>(() => new BankAccount(id, amount));
            //Assert
            Assert.AreEqual(message ,ex.Message);


           

            
        }









    }
        
}
    
    