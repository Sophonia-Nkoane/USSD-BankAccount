using System;

namespace Bank_USSD
{
    internal class BankAccount
    {
		private String _name { get; set; }
		public double? _balance { get; set; }

		public BankAccount(string name, double balance)
		{
			User user = new User()
			{
				Name = "Me",
				Balance = 1000000
			};

			_name = user.Name;
			_balance = user.Balance;
		}

		public void DebitAmount(double amount)
		{
			_balance -= amount;
		}

		public void CreditAmount(double amount)
		{
			_balance += amount;
		}
	}
}