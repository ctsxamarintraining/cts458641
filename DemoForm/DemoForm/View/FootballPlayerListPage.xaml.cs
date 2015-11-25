using System;
using SQLite;
using System.Diagnostics;
using Xamarin.Forms;


namespace DemoForm
{
	public partial class FootballPlayerListPage : ContentPage
	{
		public FootballPlayerListPage ()
		{
			InitializeComponent ();

			this.BindingContext = new FootballPlayerListViewModel ();



		}

		void OnClick (object sender, EventArgs e)
		{

			this.Navigation.PushAsync (new CreatePlayerPage ());
		
		}

	
		void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null) {
				return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
			}

			this.Navigation.PushAsync (new FootballPlayerDetailPage (e.SelectedItem));

		}

	
	}
}
