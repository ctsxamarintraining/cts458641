using System;

namespace SortExample1
{
	public class Person: IComparable
	{
		public string FirstName{ get; set;}
		public string LastName{ get; set;}
		public int Age{ get; set;}

		public Person ()
		{
			
		}

		public int CompareTo(object obj)
		{
			if (obj is Person) {
				return this.Age.CompareTo((obj as Person).Age);  // compare person age
			}
			throw new ArgumentException("Object is not a User");
		}
	}




	
	}


