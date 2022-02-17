using System;
using AbstractionExample.Models;

namespace AbstractionExample {
	public class program {
		public static void Main(string[] args) {
			Person person = new Person();

			person.name = "Gean";
			person.age = 23;

			person.Describe();
		}
	}
}