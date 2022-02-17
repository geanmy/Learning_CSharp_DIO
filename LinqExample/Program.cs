using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqExample {
	internal class program {
		public static void Main(string[] args) {
			int[] myArray = new int[] { 1, 3, 5, 10, 129, 232, 32, 1, 3, 5, 6 };

			var evenNumbers = from n in myArray where n % 2 == 0 orderby n select n;

			Console.WriteLine($"Original array: {string.Join(", ", myArray)}.");
			Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}.");
			Console.WriteLine($"Minimum value: {myArray.Min()}.");
			Console.WriteLine($"Maximum value: {myArray.Max()}.");
			Console.WriteLine($"Average value: {myArray.Average()}.");
			Console.WriteLine($"Sum of the array: {myArray.Sum()}.");
			Console.WriteLine($"Distinct array: {string.Join(", ", myArray.Distinct().ToArray())}.");
		}
	}
}