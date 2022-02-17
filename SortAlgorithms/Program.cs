using SortAlgorithms.Models;

namespace SortAlgorithms {
	internal class program {
		public static void Main(string[] args) {
			Sort sort = new Sort();

			ushort[] array = new ushort[] { 2, 5, 1, 50, 23, 45, 323, 53, 232, 1, 23, 0, 23, 43 };

			System.Console.WriteLine(string.Join(", ", array));

			sort.BubbleSort(ref array);

			System.Console.WriteLine(string.Join(", ", array));
		}
	}
}