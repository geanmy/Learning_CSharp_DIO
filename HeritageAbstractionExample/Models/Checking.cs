namespace HeritageAbstractionExample.Models {
	public sealed class Checking : Account {
		public override void AddValue(double value) {
			base.balance = value;
		}
	}
}