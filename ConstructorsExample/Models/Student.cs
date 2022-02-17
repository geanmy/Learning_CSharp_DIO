namespace ConstructorsExample.Models {
	public class Student : Person {
		float _pontuation;
		const ushort myValue = 7;

		public Student() : base(string.Empty, 0) {
			_pontuation = 0f;
		}

		public Student(string name, ushort age, float pontuation) : base(name, age) {
			_pontuation = pontuation;
		}

		public override void Describe() {
			System.Console.WriteLine($"My name is {_name} and I've {_age} years old. My pontuation is {_pontuation}. My value is {myValue}.");
		}
	}
}