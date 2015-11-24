using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using SQLite;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

namespace DemoForm
{
	public class FootballPlayerViewModel:INotifyPropertyChanged
	{

		public string cName{ get; set; }

		public string lName{ get; set; }

		public string country{ get; set; }

		public string date{ get; set; }

		public string descriptiondet{ get; set; }

		public bool fav{ get; set ; }

		public string FirstName { 
			get {
				return cName;
			}
			set {
				if (cName != value) {
					cName = value;
					OnPropertyChanged ("FirstName");
				}
			}
		}

		public string LastName {
			get {
				return lName;
			}
			set {
				if (lName != value) {
					lName = value;
					OnPropertyChanged ("LastName");
				}
			}
		}


		public string Date_of_Birth {
			get {
				return date;
			}
			set {
				if (date != value) {
					date = value;
					OnPropertyChanged ("Date_of_Birth");
				}
			}
		}


		public string Country {
			get {
				return country;
			}
			set {
				if (country != value) {
					country = value;
					OnPropertyChanged ("Country");
				}
			}
		}


		public string Description {
			get {
				return descriptiondet;
			}
			set {
				if (descriptiondet != value) {
					descriptiondet = value;
					OnPropertyChanged ("Description");
				}
			}
		}


		public bool Isfavourite {
			get {
				return fav;
			}
			set {
				if (fav != value) {
					fav = value;
					OnPropertyChanged ("Isfavourite");
				}
			}
		}



		//AGE MAY COME


		public ICommand SaveCommand{ get; set; }

		public ICommand FavouriteCommand{ get; set; }

		public ICommand DeleteCommand{ get; set; }


		public FootballPlayerViewModel ()
		{
			this.SaveCommand = new Command (() => {

			});

			this.FavouriteCommand = new Command<FootballPlayerViewModel> (execute: (FootballPlayerViewModel theplayer) => {

				using (SQLiteConnection connection = new SQLiteConnection (Path.Combine (App.folderPath, "FootballPlayerDB.db3"))) {

					List<Person> newplayerlist = connection.Query<Person> ("SELECT * FROM FootballPlayer WHERE FirstName = ? and LastName = ?", theplayer.FirstName, theplayer.LastName);

					newplayerlist [0].fav = !(newplayerlist [0].fav);
					connection.Update (newplayerlist [0]);



					Debug.WriteLine (newplayerlist.Count);
				}

				MessagingCenter.Send (this, "DBChanged");

			});

			this.DeleteCommand = new Command<FootballPlayerViewModel> (execute: (FootballPlayerViewModel theplayer) => {

				using (SQLiteConnection connection = new SQLiteConnection (Path.Combine (App.folderPath, "FootballPlayerDB.db3"))) {

					List<Person> newplayerlist = connection.Query<Person> ("SELECT * FROM FootballPlayer WHERE FirstName = ? and LastName = ?", theplayer.FirstName, theplayer.LastName);
					connection.Delete (newplayerlist [0]);



					Debug.WriteLine (newplayerlist.Count);
				}
				MessagingCenter.Send (this, "DBChanged");
			});

		}


		protected virtual void OnPropertyChanged (string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this,
					new PropertyChangedEventArgs (propertyName));
			}
		}


		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion
	}
}

