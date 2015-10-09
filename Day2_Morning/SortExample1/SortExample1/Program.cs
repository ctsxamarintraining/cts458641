using System;

namespace SortExample1
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Person[] pArray = new Person[5];

			Person p1 = new Person ();
			p1.FirstName="Nishant";
			p1.LastName="Vemula";
			p1.Age=15;
			pArray [0] = p1;

			Person p3 = new Person ();
			p3.FirstName="Nikhil";
			p3.LastName="raj";
			p3.Age=22;
			pArray [1] = p3;
			Console.WriteLine ("Hello World!");

			Person p2 = new Person ();
			p2.FirstName="Neeraj";
			p2.LastName="Nittoori";
			p2.Age=16;
			pArray [2] = p2;

			Person p4 = new Person ();
			p4.FirstName="Prashant";
			p4.LastName="Aithal";
			p4.Age=25;
			pArray [3] = p4;

			Person p5 = new Person ();
			p5.FirstName="Rohit";
			p5.LastName="Komanduri";
			p5.Age=10;
			pArray [4] = p5;


			Array.Sort (pArray);


			for (int i = 0; i < pArray.Length; i++) {

				Console.WriteLine (pArray [i].Age);

			}


		}
	}
}
