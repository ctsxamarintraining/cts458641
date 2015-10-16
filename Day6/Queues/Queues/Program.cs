using System;

namespace Queues
{
	class MainClass
	{
		int[] array = new int[7];
		int count;

		int size(int[] array){
			return array.Length;

		}



		void deQueue()
		{

			for (int i=0;i< array.Length-1;i++) 
			{

				array [i] = array [i + 1];

			}
			Array.Resize (ref array, count - 1);

		}
		void enQueue(int element){

			Array.Resize (ref array, count + 1);
			array [count++] = element;

		}
		public static void Main (string[] args)
		{
			MainClass main = new MainClass ();
			main.array [0] = 1;
			main.array [1] = 2;
			main.array [2] = 3;
			main.array [3] = 4;
			main.array [4] = 5;
			main.array [5] = 6;
			main.count = main.size (main.array);
			Console.WriteLine ("Elements before performing enQueue");
			foreach (int j in main.array) {

				Console.WriteLine (j);
			}
			main.enQueue (2);
			Console.WriteLine ("Elements after performing enQueue");
			foreach (int j in main.array) {

				Console.WriteLine (j);
			}
			main.deQueue ();
			Console.WriteLine ("Elements after dequeue operations");
			foreach (int j in main.array) {

				Console.WriteLine (j);
			}

		}
	}
}