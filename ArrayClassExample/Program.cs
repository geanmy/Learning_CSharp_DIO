using System;
using ArrayClassExample.Models;

namespace ArrayClassExample {
	internal class program {
		public static void Main(string[] args) {
			ArrayOperation op = new ArrayOperation();

			short[] array = new short[] { 5, 3, 5, 6, 1, 56, 77, 4, 43 };

			Console.WriteLine($"Before sort: {string.Join(", ", array)}");

			op.Sort(ref array);

			Console.WriteLine($"After sort: {string.Join(", ", array)}");
		}
	}
}