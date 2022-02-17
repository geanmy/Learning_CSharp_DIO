namespace PolymorphismExample.Models {
	public class SumCalculator {
		public int Sum(int[] a) {
			int result = 0;

			for(ushort i = 0; i < a.Length; i++) {
				result += a[i];
			}

			return result;
		}

		public float Sum(float[] a) {
			float result = 0;

			for(ushort i = 0; i < a.Length; i++) {
				result += a[i];
			}

			return result;
		}
	}
}