using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassTest1
{
    [TestClass]
    public class CustomerTests
    {
        private Customer customer;

        [TestMethod]
        public void SetupForTest()
        {
            customer = new Customer();
        }

        [TestMethod]
        public void ShouldCapitalizeFirstLetterInTheName()
        {
            customer.FirstName = "nina";
            Assert.AreEqual("Nina", customer.ChangeName(customer.FirstName));
        }

        [TestMethod]
        public void ShouldCapitalizeEveryWord()
        {
            customer.FirstName = "anna maria";
            Assert.AreEqual("Anna Maria", customer.ChangeName(customer.FirstName));
        }

        [TestMethod]
        public void ShouldCapitalizeFirstLetterButKeepTheRestLower()
        {
            customer.FirstName = "isAbella";
            Assert.AreEqual("Isabella", customer.ChangeName(customer.FirstName));
        }

        [TestMethod]
        public void ShouldCapitalizeFirstLetterButKeepTheRestLowerOnEveryWord()
        {
            customer.LastName = "fLOyd gREen";
            Assert.AreEqual("Floyd Green", customer.ChangeName(customer.LastName));
        }


        [TestMethod]
        public void ShouldSeparateEachPairOfNumbers()
        {
            customer.BankNumber = "22340942";
            Assert.AreEqual("22 34 09 42", customer.SplitBankNumber(customer.BankNumber));
        }

        [TestMethod]
        public void PhoneNumberHasWrongFormat()
        {
            customer.BankNumber = "29870";
            Assert.IsFalse(customer.CheckBankNumberFormat(customer.BankNumber));
        }

        [TestMethod]
        public void PhoneNumberHasGoodFormat()
        {
            customer.BankNumber = "74980225";
            Assert.IsTrue(customer.CheckBankNumberFormat(customer.BankNumber));
        }

        [TestMethod]
        public void ShouldDeleteWhiteSpacesFromTheImput()
        {
            customer.BankNumber = "223 4094 2";
            Assert.AreEqual("22 34 09 42", customer.SplitBankNumber(customer.BankNumber));
        }


    }
}