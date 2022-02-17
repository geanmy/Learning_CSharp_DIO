namespace EventExample.Models {
	public class Math1 {
		private ushort a1, b1;

		public Math1(ushort a, ushort b) {
			a1 = a;
			b1 = b;
		}

		public void Sum() {
			Calculator.opEvent += EventHandler;

			Calculator.Sum(a1, b1);
		}

		private void EventHandler() {
			System.Console.WriteLine("Event trigger!");
		}
	}
}