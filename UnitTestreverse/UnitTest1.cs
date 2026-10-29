using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using reverseprgram;

namespace UnitTestreverse
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // 1. Arrange (तयारी)
            Class1 helper = new Class1();
            int[] input = { 1, 2, 3, 4 };
            int[] expected = { 4, 3, 2, 1 }; // आपले अपेक्षित उत्तर

            // 2. Act (कृती)
            int[] actual = helper.ReverseArray(input); // मेथड कॉल केली

            // 3. Assert (तपासणी)
            // CollectionAssert वापरून दोन्ही arrays मधील व्हॅल्यूज समान आहेत का ते तपासले
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
