using System;
using PropertyExample.Models;

namespace PropertyExample {
	internal class program {
		public static void Main(string[] args) {
			Data data = new Data();

			data.month = 12;

			Console.WriteLine($"The month is {data.month}.");

			data.month = 20;

			Console.WriteLine($"The month is {data.month}.");
		}
	}
}