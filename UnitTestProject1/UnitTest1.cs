using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Debit_WithValidAmount_UpdatesBalance()
		{
			// Arrange
			double debitAmount = 4.55;
			double expected = 7.44;


			Assert.AreNotEqual(expected, debitAmount, "Account not debited correctly");
		}

		[TestMethod]
		public void Debit_WithValidAmount_UpdatesBalance_ok()
		{
			// Arrange
			double debitAmount = 7.44;
			double expected = 7.44;


			Assert.AreEqual(expected, debitAmount, "Account not debited correctly");
		}
	}
}
