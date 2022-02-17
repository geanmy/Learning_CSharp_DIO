namespace SortAlgorithms.Models {
	public class Sort {
		public void BubbleSort(ref ushort[] array) {
			ushort aux;

			for(ushort i = 0; i < array.Length; i++) {
				for(ushort j = 0; j < array.Length - 1; j++) {
					if(array[j] > array[j + 1]) {
						aux = array[j];
						array[j] = array[j + 1];
						array[j + 1] = aux;
					}
				}
			}
		}
	}
}