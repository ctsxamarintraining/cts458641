using System;
using SQLite;
using Xamarin.Forms;
using System.Linq;

namespace DemoForm
{
	public class MyPage : ContentPage
	{
		SQLiteConnection database;

		public MyPage ()
		{
			RelativeLayout stack = new RelativeLayout ();
			var myImage = new Image { Source = "Default.png", Opacity = 0.5 };



			var button = new Button { Text = "GoToForm", BackgroundColor = Color.Gray };
			stack.HorizontalOptions = LayoutOptions.Center;
			stack.VerticalOptions = LayoutOptions.Center;

			stack.Children.Add (myImage, Constraint.Constant (0), Constraint.Constant (0));
			stack.Children.Add (button, Constraint.Constant (130), Constraint.Constant (200));


			button.Clicked += (sender, e) => {
				database = DependencyService.Get<ISQLite> ().GetConnection ();
				var stockList = database.Table<Person> ();
				System.Diagnostics.Debug.WriteLine (stockList);
				//this.Navigation.PushAsync (new FormPage ());
				//	this.Navigation.PushAsync (new FootballPlayerPage (stockList));
			};

			this.Content = stack;




		}
	}
}
