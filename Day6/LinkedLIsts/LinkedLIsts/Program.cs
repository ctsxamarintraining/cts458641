using System;
using System.Collections.Generic;
using System.Collections;

namespace LinkedList
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//			Implement double LinkedList for a Person class (which contains Id, Name , Location properties) 
			//				and use enumerator to iterate through each item and print the values on console. 
			MyEnum myEnumObj = new MyEnum();
			foreach (Person p in myEnumObj)
				Console.WriteLine ("Id is {0} , Name is {1} , Location is {2}", p.Id, p.Name, p.Location);

		}
	}
	class Person{
		public int Id;
		public string Name;
		public string Location;
	}
	class MyEnumerator : IEnumerator{
		public static LinkedList<Person> myPersonLinkedList;

		public LinkedListNode<Person> currentObj;
		public object Current {
			get{
				return currentObj.Value;
			}
		}

		public bool MoveNext (){
			if (myPersonLinkedList == null) {
				myPersonLinkedList = new LinkedList<Person>();
				myPersonLinkedList.AddLast(new Person{Id=1,Name="John",Location="hyd"});
				myPersonLinkedList.AddLast(new Person{Id=2,Name="Daniel",Location="Delhi"});
				myPersonLinkedList.AddLast(new Person{Id=3,Name="Popeye",Location="mumbai"});
				myPersonLinkedList.AddLast(new Person{Id=4,Name="Tom",Location="pune"});
			}
			if (currentObj == null && myPersonLinkedList.First != null) {

				currentObj = myPersonLinkedList.First;
				return true;
			} 
			if ( currentObj.Next!=null) {
				currentObj = currentObj.Next;
				return true;
			} else {
				return false;
			}

		}

		public void Reset (){
			currentObj = null;
		}
	}
	class MyEnum : IEnumerable{
		public IEnumerator GetEnumerator (){
			return new MyEnumerator ();
		}
	}
}