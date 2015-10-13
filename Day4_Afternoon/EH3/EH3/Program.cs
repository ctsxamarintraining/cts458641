using System;
using System.IO;

namespace ExceptionEx2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			try{
				string fpath ;
				Console.Write("Enter file path : ");
				fpath = Console.ReadLine();
				Console.WriteLine("The contents of file are :\n" +File.ReadAllText(fpath));
			}
			catch(FormatException e){
				Console.WriteLine ("Inside format exception");

				Console.WriteLine (e.Message);
			}
			catch(FileNotFoundException e){
				Console.WriteLine ("Inside file not found exception");

				Console.WriteLine (e.Message);
			}
			catch(FileLoadException e){
				Console.WriteLine ("Inside file load exception");

				Console.WriteLine (e.Message);
			}
			catch(Exception e){
				Console.WriteLine ("Inside exception");

				Console.WriteLine (e.Message);
			}
		}
	}
}