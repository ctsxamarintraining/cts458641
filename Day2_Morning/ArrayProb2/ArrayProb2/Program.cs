using System;

namespace ArrayProb2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[,] newArray = new int[4,2]{ {1,3},{15,7},{80,2},{99,1}};
			PrintTheArray (newArray);
		}

		static void PrintTheArray(Array theArray)
		{
			foreach (var e in theArray)
				Console.WriteLine (e);
		}
	}
}
