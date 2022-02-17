using System;
using PolymorphismExample.Models;

namespace PolymorphismExample {
	internal class program {
		public static void Main(string[] args) {
			SumCalculator sumCalc = new SumCalculator();
			Student student = new Student();

			student.Describe();
			Console.WriteLine($"O resultado da primeira soma é {sumCalc.Sum(new int[] {10, 20, 30})}.\nO resultado da segunda soma é {sumCalc.Sum(new float[] {10.0f, 50.50f, 30.40f})}");
		}
	}
}