namespace EncapsulationExample.Models {
	public class Rectangle {
		private double length, width;

		public void SetDimensions(double length, double width) {
			if(length > 0 && width > 0) {
				this.length = length;
				this.width = width;
			}
		}

		public double GetArea() {
			return length * width;
		}
	}
}