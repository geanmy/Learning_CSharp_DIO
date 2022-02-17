using System;

namespace PolymorphismExample.Models {
	public class Student : Person {
		public override void Describe() {
			Console.WriteLine($"Hello, my name is {name} and I like wine!");
		}
	}
}