using System;

namespace Generics_Q1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("list 1 - Add 1st");
			Console.WriteLine ();
			LinkedList<string> myList1 = new LinkedList<string>();

			myList1.AddFirst("Hello");
			myList1.AddFirst("Yes");
			myList1.AddFirst("No");
			myList1.AddFirst ("Maybe");
			myList1.AddFirst ("Cant say");
			myList1.AddFirst ("end");
			myList1.printAllNodes();

			Console.WriteLine();

			Console.WriteLine("list 2 - Add Last");
			Console.WriteLine ();


			LinkedList<string> myList2 = new LinkedList<string>();
			myList2.AddLast("India");
			myList2.AddLast("South Africa");
			myList2.AddLast("Pakistan");
			myList2.AddLast ("Sri Lanka");
			myList2.AddLast ("Maldives");
			myList2.AddLast ("USA");
			myList2.printAllNodes();


			Console.WriteLine("list 1 - remove 1st");
			Console.WriteLine ();

			myList1.RemoveFirst ();
			myList1.printAllNodes();

			Console.WriteLine("list 2 - remove 2nd");
			Console.WriteLine ();

			myList2.RemoveLast ();
			myList2.printAllNodes();


			Console.ReadLine();
		}
	}
}