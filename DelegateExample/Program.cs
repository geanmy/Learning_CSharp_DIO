using System;
using DelegateExample.Models;

namespace DelegateExample {
	internal class program {
		public delegate void Operation(ushort a, ushort b);

		public static void Main(string[] args) {
			Operation op = Calculator.Sum;
			op += Calculator.Sub;

			op(10, 10);
		}
	}
}