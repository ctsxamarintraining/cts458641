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
			Person p = new Person ();
			var x1 = (MenuItem)sender;
			var x2 = x1.BindingContext;
			Person x3 = (Person)x2;
			x3.deletePlayer (x3.key);

			MessagingCenter.Send (this, "delete");

			SQLiteConnection database;
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			database.Update (p);



			var stockList = database.Table<Person> ();

			this.Navigation.PushAsync (new FootballPlayerListPage (stockList));

		}

		void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null) {
				return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
			}

			this.Navigation.PushAsync (new FootballPlayerDetailPage (e.SelectedItem));

			//((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
		}

		void Favourites_Clicked (object sender, EventArgs e)
		{

			MenuItem button = (MenuItem)sender;

			var x1 = (MenuItem)sender;
			var x2 = x1.BindingContext;
			Person x3 = (Person)x2;
			x3.fav =	!x3.fav;
			if (x3.fav) {


				button.Text = "Un Favourite";
			} else {
				button.Text = "Mark Favourite";
			}
			x3.updateplayerFavourite (x3);
		}



		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			Person dat = new Person ();
			FootballPlayerPages1.ItemsSource = dat.GetItems ();

		}
	}
}
