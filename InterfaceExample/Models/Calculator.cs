using InterfaceExample.Interfaces;

namespace InterfaceExample.Models {
	public class Calculator : ICalculator {
		public int Sum(int num1, int num2) {
			return num1 + num2;
		}

		public int Sub(int num1, int num2) {
			return num1 - num2;
		}

		public int Mul(int num1, int num2) {
			return num1 * num2;
		}

		public int Div(int num1, int num2) {
			return num1 / num2;
		}
	}
}