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
		public void GetPrimeListReturnsCorrectFirst10PrimeNumbers()
		{
			//Arrange 
			Prime primeObj = new Prime();
			List<int> expectedList = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
			List<int> actualList;

			//Act
			actualList = primeObj.GetPrimeList(10);
			
			//Assert
			//Lists are equal length
			Assert.AreEqual(expectedList.Count, actualList.Count);

			//Lists have the same numbers (Liang TODO)
			
		}
	}
}
