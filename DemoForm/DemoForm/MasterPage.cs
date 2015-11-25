using System;
using System.Collections;
using SQLite;
using Xamarin.Forms;

namespace DemoForm
{
	public class MasterPage : Xamarin.Forms.MasterDetailPage
	{
		public MasterPage ()
		{
			SQLiteConnection database;

			database = DependencyService.Get<ISQLite> ().GetConnection ();



			database.CreateTable<Person> ();
			//	database.Insert (personObj);	
			//			
			//
			//
			//var stockList = database.Table<Person> ();


			Label header = new Label {
				Text = "MasterDetailPage",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};

			string[] array = new string[]{ "List", "CarouselPage", "TabbedPage" };

			ListView listView = new ListView {
				ItemsSource = array
			};


			this.Master = new ContentPage {
				Title = header.Text,
				Content = new StackLayout {
					Children = {
						header, 
						listView
					}
				}
			};

			this.Detail = new NavigationPage (new FootballPlayerListPage ());
			//var stockList = database.Table<Person> ();

			//	Person personObj = new Person (firstname.Text, g.Text, description.Text, datePicker.Date.ToString (), array [picker.SelectedIndex]);
		
			//		
			listView.ItemSelected += (sender, args) => {
				if (listView.SelectedItem.ToString () == "List") {
					
					this.Detail = new NavigationPage (new FootballPlayerListPage ());
				} else if (listView.SelectedItem.ToString () == "CarouselPage") {
					this.Detail = new NavigationPage (new CarouselPage ());
				} else {
					this.Detail = new NavigationPage (new TabbedPage ());
				}
				this.Detail.BindingContext = args.SelectedItem;
				this.IsPresented = false;

			};
		}
	}
}
