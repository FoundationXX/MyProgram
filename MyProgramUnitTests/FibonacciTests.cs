using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram.Tests
{
    [TestClass()]
    public class FibonacciTests
    {
        [TestMethod()]
        /// As assumed in the method, the first two fibonacci numbers should be 0,1
        public void GetFibonacciListTestReturnsFirst2FibonacciNumbers()
        {
            Fibonacci fibonacciObj1 = new Fibonacci();
            List<double> expectedList =new List<double>() {0,1};
            List<double> actualList = fibonacciObj1.GetFibonacciLister(2);
            Assert.AreEqual(expectedList.Count, actualList.Count);
            for(int i = 0; i <expectedList.Count; i++)
            {
                Assert.AreEqual(expectedList[i], actualList[i]);
            }

        }


        [TestMethod()]
        public void GetFibonacciListTestReturnsFirst20FibonacciNumbers()
        {

            Fibonacci fibonacciObj2 = new Fibonacci();
            List<double> expectedList = new List<double>() { 0, 1, 1, 2, 3,  5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181};
            List<double> actualList = fibonacciObj2.GetFibonacciLister(20);
            Assert.AreEqual(expectedList.Count, actualList.Count);
            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.AreEqual(expectedList[i], actualList[i]);
            }
        }
    }
}