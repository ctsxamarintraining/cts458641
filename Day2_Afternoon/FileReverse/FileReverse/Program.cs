using System;
using System.IO;
namespace FileReverse
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			FileStream fstream = new FileStream("Yourfile.txt", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writerstream = new StreamWriter(fstream);
			writerstream.Write("Hello there Welcome ");
			writerstream.Close();


			TextReader treader = new StreamReader("Yourfile.txt");


		
			string FileString=treader.ReadToEnd();
			char []stringArray = FileString.ToCharArray();
			Array.Reverse(stringArray);
			string newStr = new string(stringArray);
			Console.WriteLine (newStr);
			treader.Close();


			FileStream fstream2= new FileStream("Yourfile1.txt", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writerstream1 = new StreamWriter(fstream2);
			writerstream1.Write(newStr);
			writerstream1.Close();



		}
	}
}
