namespace HeritageExample.Models {
	internal class Person {
		private string name { get; set; }
		private ushort age { get; set; }

		public void SetValues(string name, ushort age1) {
			VerifyAndSetValues(name, age);
		}

		protected void VerifyAndSetValues(string name, ushort age) {
			if(!string.IsNullOrEmpty(name) && age > 0) {
				this.name = name;
				this.age = age;
			}
		}

		public string GetName() {
			return name;
		}

		public ushort GetAge() {
			return age;
		}
	}
}