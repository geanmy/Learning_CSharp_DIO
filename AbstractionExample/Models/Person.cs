using System;

namespace AbstractionExample.Models {
	public class Person {
		public string name { get; set; }
		public ushort age { get; set; }

		public void Describe() {
			Console.WriteLine($"My name is {name} and I have {age} years old!");
		}
	}
}