using System;
using System.IO;
using System.Collections.Generic;

namespace FileManagmentExample {
	internal class program {
		public static void Main(string[] args) {
			string path = "D:/Gean/FileManagmentTestFolder/";
			List<string> dataList = new List<string>() { "Line 1", "Line 2", "Line 3" };

			//GetDirectories(path);
			//GetFilesTXTAndDirectories(path);
			//CreateDirectory(path, "Pasta Teste 3");
			//DeleteDirectory(Path.Combine(path, "Pasta Teste 3"), true);
			//FileWrite(Path.Combine(path, "teste.txt"), "Testing...1, 2, 3...Testing.");
			FileWriteStream(Path.Combine(path, "testStream.txt"), dataList);
		}

		private static void GetDirectories(string path) {
			string[] directories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

			for(ushort i = 0; i < directories.Length; i++) {
				Console.WriteLine(directories[i]);
			}
		}

		private static void GetFilesTXTAndDirectories(string path) {
			string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

			for(ushort i = 0; i < files.Length; i++) {
				Console.WriteLine(files[i]);
			}
		}

		private static void CreateDirectory(string originPath, string folderName) {
			DirectoryInfo dirInfo = Directory.CreateDirectory(Path.Combine(originPath, folderName));

			if(dirInfo.Exists) {
				Console.WriteLine("Directory created!");
			}
		}

		private static void DeleteDirectory(string path, bool recursive) {
			Directory.Delete(path, recursive);
		}

		private static void FileWrite(string filePath, string data) {
			if(!File.Exists(filePath)) {
				File.WriteAllText(filePath, data);
			}
		}

		private static void FileWriteStream(string filePath, List<string> dataList) {
			using (StreamWriter writer = File.CreateText(filePath)) {
				for(ushort i = 0; i < dataList.Count(); i++) {
					writer.WriteLine(dataList[i]);
				}
			}
		}

		private static void FileAppend(string filePath, string data) {
			File.AppendAllText(filePath, data);
		}

		private static void FileAppendStream(string filePath, List<string> dataList) {
			using (StreamWriter writer = File.AppendText(filePath)) {
				for(ushort i = 0; i < dataList.Count(); i++) {
					writer.WriteLine(dataList[i]);
				}
			}
		}

		private static void ReadFile(string filePath) {
			string[] data = File.ReadAllLines(filePath);

			for(ushort i = 0; i < data.Length; i++) {
				Console.WriteLine(data);
			}
		}

		private static void ReadStream(string filePath) {
			string line = string.Empty;

			using (StreamReader stream = File.OpenText(filePath)) {
				while((line = stream.ReadLine()) != null) {
					Console.WriteLine(line);
				}
			}
		}

		private static void Move(string filePath, string newFilePath) {
			File.Move(filePath, newFilePath);
		}

		private static void Copy(string filePath, string newFilePath) {
			File.Copy(filePath, newFilePath);
		}

		private static void Delete(string filePath) {
			File.Delete(filePath);
		}
	}
}