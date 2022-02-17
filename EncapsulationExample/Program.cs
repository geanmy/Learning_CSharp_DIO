using System;
using EncapsulationExample.Models;

namespace EncapsulationExample {
	internal class program {
		public static void Main(string[] args) {
			Rectangle rect = new Rectangle();

			rect.SetDimensions(10, 15);

			Console.WriteLine($"The rectangle area is {rect.GetArea()}.");
		}
	}
}