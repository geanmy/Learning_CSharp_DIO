using System;
using InterfaceExample.Models;

namespace InterfaceExample {
	internal class program {
		public static void Main(string[] args) {
			Calculator calc = new Calculator();

			Console.WriteLine($"Resultado da soma: {calc.Sum(10, 11)}.");
			Console.WriteLine($"Resultado da subtração: {calc.Sub(10, 11)}.");
			Console.WriteLine($"Resultado da multiplicação: {calc.Mul(10, 11)}.");
			Console.WriteLine($"Resultado da divisão: {calc.Div(10, 10)}.");
		}
	}
}