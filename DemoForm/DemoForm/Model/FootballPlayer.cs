using System;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using System.Diagnostics;


namespace DemoForm
{

	public class Person
	{
		[PrimaryKey,AutoIncrement]
		public int key{ get; set; }

		public Person ()
		{
			
		}

		public string cName{ get; set; }

		public string lName{ get; set; }

		public string country{ get; set; }

		public string date{ get; set; }

		public string descriptiondet{ get; set; }

		public bool fav{ get; set ; }



		public Person (string customerName, string lastName, string countrySelected, string dateSelected, string description, bool f)
		{
			cName = customerName;
			lName = lastName;
			country = countrySelected;
			date = dateSelected;
			descriptiondet = description;
			f = fav;
		}

	
		public void deletePlayer (int myId)
		{
			SQLiteConnection database;
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			database.CreateTable<Person> ();
			database.Delete<Person> (myId);
		}

		public void updateplayerFavourite (Person obj)
		{
			SQLiteConnection database;
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			database.CreateTable<Person> ();
			database.Update (obj);

		}

		public IEnumerable<Person> GetItems ()
		{

			SQLiteConnection database;

			database = DependencyService.Get<ISQLite> ().GetConnection ();



			var myList = from i in database.Table<Person> ()
			             select i;
			var FavSort = from player in myList
				orderby player.fav descending
			              select player;

			var sort2 = FavSort.OrderBy ((x => x.cName));
			return sort2;


		}


		public string countryImage {

			get {

				var c = String.Concat (country, ".png");
				return c;
			}
		}

	}
}
