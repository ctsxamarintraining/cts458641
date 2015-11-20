using System;
using System.Collections.Generic;
using SQLite;

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
			//ToolbarItem tbi = (ToolbarItem) sender;
			//this.DisplayAlert("Selected!", tbi.Name,"OK");
		}


	}
}
