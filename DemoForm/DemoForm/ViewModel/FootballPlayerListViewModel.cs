using System;
using System.Collections.ObjectModel;
using SQLite;
using System.Collections.Generic;
using System.Collections;

namespace DemoForm
{
	public class FootballPlayerListViewModel
	{


		public string cName{ get; set; }

		public string lName{ get; set; }

		public string country{ get; set; }

		public string date{ get; set; }

		public string descriptiondet{ get; set; }

		public FootballPlayerListViewModel (TableQuery<Person> personObjects)
		{
			Football_Player = new ObservableCollection<Person> ();



			foreach (Person p in personObjects) {

				Football_Player.Add (p);
			}


		}

		public ObservableCollection<Person> Football_Player{ get; set; }
	}
}
