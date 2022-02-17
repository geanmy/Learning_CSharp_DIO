namespace PropertyExample.Models {
	public class Data {
		private ushort Month;

		public ushort month { 
			get {
				return this.Month;
			}

			set {
				if(value > 0 && value <= 12) {
					this.Month = value;
				}
			}
		}
	}
}