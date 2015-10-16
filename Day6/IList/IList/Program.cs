using System;
using System.Collections.Generic;
using System.Collections;

namespace IListDemo
{
	class MainClass
	{
		public static void Main (string[] args)
		{ //Console.Write ("gfdhsghy");

			Mylist test = new Mylist();

			// Populate the List
			Console.WriteLine("Populate the List");
			test.Add("a");
			test.Add("1");
			test.Add("b");
			test.Add("2");
			test.Add("c");
			test.Add("3");
			test.Add("d");
			test.Add("4");
			test.Printarray();
			Console.WriteLine();

			// Remove elements from the list
			Console.WriteLine("Remove elements from the list");
			test.Remove("d");
			test.Remove("4");
			test.Printarray();
			Console.WriteLine();

			// Add an element to the end of the list
			Console.WriteLine("Add an element to the end of the mylist");
			test.Add("e");
			test.Printarray();
			Console.WriteLine();

			// Insert an element into the middle of the list
			Console.WriteLine("Insert an element into the middle of the list");
			test.Insert(4, "9");
			test.Printarray();
			Console.WriteLine();

			// Check for specific elements in the list
			Console.WriteLine("Check for specific elements in the list");
			Console.WriteLine("List contains \"three\": {0}", test.Contains("a"));
			Console.WriteLine("List contains \"four\": {0}", test.Contains("b"));


		}
	}
}