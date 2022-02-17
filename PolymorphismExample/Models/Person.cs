using System;

namespace PolymorphismExample.Models {
	public class Person {
		protected string name = "Gean";

		public virtual void Describe() {
			Console.WriteLine($"Hello, my name is {name}.");
		}
	}
}