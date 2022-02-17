using System;
using HeritageExample.Models;

namespace HeritageExample {
	internal class program {
		public static void Main(string[] args) {
			Student student = new Student();

			student.SetValues("Gean", 23, 10);

			Console.WriteLine($"Student {student.GetName()} have {student.GetAge()} years old.\nHis/Her pontuation is {student.GetPontuation()}");
		}
	}
}