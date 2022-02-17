namespace DelegateExample.Models {
	public class Calculator {
		public static void Sum(ushort a, ushort b) {
			System.Console.WriteLine($"Sum: {a + b}.");
		}

		public static void Sub(ushort a, ushort b) {
			System.Console.WriteLine($"Sub: {a - b}.");
		}
	}
}