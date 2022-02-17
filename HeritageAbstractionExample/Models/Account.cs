using System;

namespace HeritageAbstractionExample.Models {
	public abstract class Account {
		protected double balance;

		public abstract void AddValue(double value);

		public sealed void ShowBalance() {
			Console.WriteLine($"Your balance is {balance}.");
		}
	}
}