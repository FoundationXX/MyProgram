using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MyProgram;

namespace MyProgramUnitTests
{
	/// <summary>
	/// Class to test methods in Prime class
	/// </summary>
	[TestClass]
	public class PrimeTests
	{

		[TestMethod]
		public void PrimeNumberListerReturnsCorrectFirst10PrimeNumbers()
		{
			//Arrange 
			Prime primeObj = new Prime();
			List<double> expectedList = new List<double>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
			List<double> actualList;

			//Act, get all prime numbers between 0 and 30 which covers the expected list exactly
			actualList = primeObj.PrimeNumberLister(30);
			
			//Assert
			//Lists are equal length
			Assert.AreEqual(expectedList.Count, actualList.Count);

			//Lists have the same numbers
            for(int i = 0; i < expectedList.Count; i++)
            {
                Assert.AreEqual(expectedList[i], actualList[i]);
            }
			
		}
	}
}
