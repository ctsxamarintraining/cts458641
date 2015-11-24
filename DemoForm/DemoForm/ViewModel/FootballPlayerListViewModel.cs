using System;
using System.Collections.ObjectModel;
using SQLite;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using Xamarin.Forms;
using System.ComponentModel;

namespace DemoForm
{
	public class FootballPlayerListViewModel: INotifyPropertyChanged
	{


		private ObservableCollection<Person> theFootball_Player_List{ get; set; }

		public ObservableCollection<Person> Football_Player_List {
			get {
				return theFootball_Player_List;
			}
			set {
				if (theFootball_Player_List != value) {
					theFootball_Player_List = value;
					OnPropertyChanged ("Football_Player_List");
				}
			}
		}

		public FootballPlayerListViewModel ()
		{
			UpdateTheList ();
			MessagingCenter.Subscribe<Person> (this, "SomethingHappened", (OBJ) => {
				UpdateTheList ();
			}, null);
		}

		private void UpdateTheList ()
		{
			ObservableCollection<Person> coll = new ObservableCollection<Person> ();
			using (SQLiteConnection connection = DependencyService.Get<ISQLite> ().GetConnection ()) {
				var list = connection.Query<Person> ("SELECT * FROM PERSON ORDER BY FAV DESC,CNAME ASC");				
				foreach (var item in list) {
					coll.Add (item);
				}
			}
			Football_Player_List = coll;
		}


		protected virtual void OnPropertyChanged (string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this,
					new PropertyChangedEventArgs (propertyName));
				//OnPropertyChanged ("PropertyChanged");
			}
		}

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion
	}

}
