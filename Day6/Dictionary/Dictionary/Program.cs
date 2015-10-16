using System;
using System.Collections.Generic;

namespace Dictionary
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Dictionary<string,int> dict=new Dictionary<string,int>();
			dict.Add("one",1);
			dict.Add("two",2);
			dict.Add("three",3);
			dict.Add("four",4);
			dict.Remove("one");
			Console.WriteLine ("Before contains");
			Console.WriteLine(dict.ContainsKey("dsaf"));
			Console.WriteLine("Key Value Pairs after Dictionary related operations:\n");
			foreach (var pair in dict)
			{
				Console.WriteLine("{0}, {1}",
					pair.Key,
					pair.Value);
			}

			dict.Clear ();


			List<string> strList = new List<string> ();
			strList.Add ("one");
			strList.Add ("two");
			strList.Add ("three");
			strList.Add ("four");
			strList.Add ("five");
			strList.Insert (3, "great");
			string[] newList = new string[3]{ "ten", "eleven", "twelve" };
			strList.AddRange (newList);
			strList.InsertRange (3, newList);

			Console.WriteLine ("Output after all list related  operations i.e. add, insert, addrange, insertrange,remove\n");
			Console.WriteLine ("The list");
			foreach (var i in strList)
				Console.WriteLine (i);






		}
	}
}