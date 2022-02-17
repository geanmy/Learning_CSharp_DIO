namespace HeritageExample.Models {
	internal class Student : Person {
		private ushort pontuation { get; set; }

		public void SetValues(string name, ushort age, ushort pontuation) {
			VerifyAndSetValues(name, age);

			this.pontuation = pontuation;
		}

		public ushort GetPontuation() {
			return pontuation;
		}
	}
}