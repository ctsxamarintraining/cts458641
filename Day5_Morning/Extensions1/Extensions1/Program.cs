using System;

namespace Extension
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string Sentence=null;
			int NoOfWords = 0;
			int totalCharWoSpace = 0;
			Console.WriteLine("Enter the the sentence");
			Sentence = Console.ReadLine();
			//calling Extension Method WordCount
			NoOfWords = Sentence.WordCountExtension();
			Console.WriteLine("Total number of words is/are :"+ NoOfWords);
			//calling Extension Method to count character
			totalCharWoSpace = Sentence.TotalCharWithoutSpace();
			Console.WriteLine("Total number of characters is/are :"+totalCharWoSpace);
			Console.ReadKey();
		}
	}

	public static class ExtensionMethod
	{
		public static int WordCountExtension(this string str)
		{
			string[] userString = str.Split(new char[] { ' ', '.', '?' },
				StringSplitOptions.RemoveEmptyEntries);
			int wordCount = userString.Length;
			return wordCount;
		} 
		public static int TotalCharWithoutSpace(this string str)
		{
			int totalCharWithoutSpace = 0;
			string[] userString = str.Split(' ');
			foreach (string stringValue in userString)
			{
				totalCharWithoutSpace += stringValue.Length;
			}
			return totalCharWithoutSpace;
		}
	}
}
