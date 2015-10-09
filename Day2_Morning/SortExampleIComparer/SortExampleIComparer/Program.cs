using System;
using System.Collections;

namespace SortExampleIComparer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] pArray = new Person[4];

			pArray [0] = new Person( "Rohit", 20 );
			pArray [1] = new Person("pashu", 20 );
			pArray [2] = new Person( "Neer", 20 );
			pArray [3] = new Person("Adil", 20 );


			Array.Sort(pArray, Person.SortByName);

			for (int i = 0; i < pArray.Length; i++) {

				Console.WriteLine (pArray[i].name);
			}
		}
	}
}
