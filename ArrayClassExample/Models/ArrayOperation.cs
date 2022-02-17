using System;

namespace ArrayClassExample.Models {
	public class ArrayOperation {
		public void Sort(ref short[] array) => Array.Sort(array);

		public void Copy(ref short[] source, ref short[] destination) => Array.Copy(source, destination, source.Length);

		public bool Exists(ref short[] array, short Value) {
			return Array.Exists(array, x => x == Value);
		}

		public bool AllGreaterThan(ref short[] array, short Value) {
			return Array.TrueForAll(array, x => x > Value);
		}

		public bool IsThere(ref short[] array, short Value) {
			return (Array.Find(array, x => x == Value) > 0) ? true : false;
		}

		public short Index(ref short[] array, short Value) {
			return (short) Array.IndexOf(array, Value);
		}

		public void Resize(ref short[] array, short newSize) => Array.Resize(ref array, newSize);

		public string[] ConvertToString(ref short[] array) {
			return Array.ConvertAll(array, x => x.ToString());
		}
	}
}