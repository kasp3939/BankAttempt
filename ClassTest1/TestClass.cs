using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassTest1
{
    [TestClass]
    public class TestClass
    {
        [TestClass]
        public class CustomerTests
        {
            private Customer customer;

            [TestInitialize]
            public void SetuoForTest()
            {
                customer = new Customer();
            }

        }
    }
}
