using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Test.Transactions.Test
{
    class Transactions
    {
        [Fact]

		public void Deposit_ValidAmount_IncreasesBalance()
		{
			// Arrange
			var accountNumber = "123456"; // Replace with a valid account number
			var initialBalance = 100.0; // Replace with the initial balance
			var depositAmount = 50.0; // Replace with the deposit amount

			//Arrange
			YourClassContainingDepositMethod.Deposit(depositAmount);

			// Assert
			// Retrieve the customer's updated balance after the deposit
			var updatedBalance = GetCustomerBalance(accountNumber); // Implement this method to retrieve the balance.

			// Assert that the updated balance is the initial balance plus the deposit amount.
			Assert.Equal(initialBalance + depositAmount, updatedBalance, precision: 2); // Use a precision value that's appropriate for your use case.
		}

		

		//Act


		//Assert

	}
}
