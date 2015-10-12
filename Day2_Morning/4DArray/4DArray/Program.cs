using System;
namespace DataArray
{
class Program
{
	static void Main()
	{

		string[, , ,] fourdimension = new string[3, 2, 2, 2];
			fourdimension [0, 0, 0, 0] = "one";
			fourdimension [0, 0, 0, 1] = "two";
			fourdimension [0, 0, 1, 0] = "three";
			fourdimension [0, 0, 1, 1] = "four";
			fourdimension [0, 1, 0, 0] = "five";
			fourdimension [0, 1, 1, 1] = "six";
			fourdimension [0, 1, 1, 0] = "seven";
			//fourdimension [0, 1, 1, 1] = "eight";
			fourdimension [1, 0, 0, 0] = "nine";
			fourdimension [1, 1, 1, 1] = "ten";
			fourdimension [1, 0, 1, 0] = "eleven";
			fourdimension [1, 0, 1, 1] = "twelve";
			fourdimension [1, 1, 1, 0] = "thirteen";
			fourdimension [0, 1, 1, 1] = "fourteen";
			fourdimension [0, 1, 0, 1] = "fifteen";
			fourdimension [1, 0, 0, 1] = "eight";
			fourdimension [1, 1, 0, 0] = "fourteen";



		// Loop over each dimension's length.
			for (int i = 0; i < fourdimension.GetLength(3); i++)
		{
				for (int y = 0; y < fourdimension.GetLength(2); y++)
			{
					for (int x = 0; x < fourdimension.GetLength(1); x++)
				{
						for(int z=0; z< fourdimension.GetLength(0); z++)
						{
							
							Console.Write(fourdimension[x, y, z, i]);
							Console.WriteLine ('\n');
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
	}