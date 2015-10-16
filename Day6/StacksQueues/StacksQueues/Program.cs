using System;

namespace Stack
{
	class MainClass
	{
		int[] array = new int[5];
		int count=0;

		int size(int[] arr){

			return arr.Length;

		}

		void push(int element)
		{
			Array.Resize (ref array, count+1);
			array [count++] = element;


		}
		void pop()
		{
			Array.Resize (ref array, count - 1);
		}

		public static void Main (string[] args)
		{
			MainClass main = new MainClass ();
			main.array [0] = 1;
			main.array [1] = 2;
			main.array [2] = 3;
			main.array [3] = 4;
			main.array [4] = 5;
			main.count = main.size (main.array);
			main.push (6);
			main.push (7);
			main.pop ();
			//Console.Write (main.array.ToString());
			Console.WriteLine("Elements after performing operations");
			foreach (int i in main.array)
				Console.WriteLine (i);
		}



	}
}