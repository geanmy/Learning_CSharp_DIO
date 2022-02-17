using System;
using ConstructorsExample.Models;

namespace ConstructorsExample {
	internal class program {
		public static void Main(string[] args) {
			Student student = new Student();
			Student student2 = new Student("Gean", 23, 10f);
			log log = log.GetInstance();
			log log2 = log.GetInstance();

			student.Describe();
			student2.Describe();

			log.line = "Test.";
			Console.WriteLine(log2.line);
		}
	}
}