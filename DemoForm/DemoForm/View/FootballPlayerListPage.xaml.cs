using System;


using SQLite;
using System.Diagnostics;
using Xamarin.Forms;


namespace DemoForm
{
	public partial class FootballPlayerListPage : ContentPage
	{
		public FootballPlayerListPage (TableQuery<Person> personObjects)
		{
			this.BindingContext = new FootballPlayerListViewModel (personObjects);
			InitializeComponent ();



		}

		void OnClick (object sender, EventArgs e)
		{

			this.Navigation.PushAsync (new FormPage ());
		
		}

		public void OnDelete (object sender, EventArgs e)
		{
//			var mi = ((MenuItem)sender);
//			//DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
//
//			Debug.WriteLine ("delete " + mi.CommandParameter.ToString ());
//			//items.Remove (mi.CommandParameter.ToString ());
		}

		void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null) {
				return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
			}
			SQLiteConnection database;

			database = DependencyService.Get<ISQLite> ().GetConnection ();



			database.CreateTable<Person> ();
			//	database.Insert (personObj);	
			//			
			//
			//
			var stockList = database.Table<Person> ();
			this.Navigation.PushAsync (new FootballPlayerDetailPage (e.SelectedItem));

			//((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
		}
	}
}
