using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using addition;
namespace UnitTestAdd
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange 
            int expected = 68;
            Class1 c1 = new Class1();


            //Act
            int actual = c1.Add();

            //Assert
            Assert.AreEqual(expected,actual);
            
        }
    }
}
