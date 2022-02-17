namespace EventExample.Models {
	public class Calculator {
		public delegate void Operation();

		public static event Operation opEvent;

		public static void Sum(ushort a, ushort b) {
			if(opEvent != null) {
				System.Console.WriteLine($"Sum: {a + b}.");
				opEvent();
			} else {
				System.Console.WriteLine("No subscribers to Calculator Event.");
			}
		}
	}
}