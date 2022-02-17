namespace ConstructorsExample.Models {
	public class Person {
		protected readonly string _name;
		protected readonly ushort _age;

		public Person(string name, ushort age) {
			_name = name;
			_age = age;
		}

		public virtual void Describe() {
			System.Console.WriteLine($"My name is {_name} and I've {_age} years old.");
		}
	}
}