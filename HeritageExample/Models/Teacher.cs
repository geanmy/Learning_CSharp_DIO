namespace HeritageExample.Models {
	internal class Teacher : Person {
		private float salary { get; set; }

		public void SetValues(string name, ushort age, float salary) {
			VerifyAndSetValues(name, age);

			this.salary = salary;
		}

		public float GetSalary() {
			return salary;
		}
	}
}