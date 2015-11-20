using System;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using System.Diagnostics;


namespace DemoForm
{

	public class FormPage : ContentPage
	{

		SQLiteConnection database;

		public FormPage ()
		{
			RelativeLayout layout = new RelativeLayout { Padding = 10 };
			var label = new Label {
				Text = "Details Page",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),

			};

			layout.Children.Add (label, Constraint.Constant (120), Constraint.Constant (5));

			var firstNamelabel = new Label {
				Text = "First Name"
			};
			layout.Children.Add (firstNamelabel, Constraint.Constant (40), Constraint.Constant (60));

			var firstname = new Entry {
				Placeholder = "Enter the Name"
			};
			layout.Children.Add (firstname, Constraint.Constant (135), Constraint.Constant (60));

			var lastNameLabel = new Label {
				Text = "Last Name"
			};
			layout.Children.Add (lastNameLabel, Constraint.Constant (40), Constraint.Constant (100));

			var lastname = new Entry {
				Placeholder = "Enter the Name"
			};
			layout.Children.Add (lastname, Constraint.Constant (135), Constraint.Constant (100));




			var Gender = new Label {
				Text = "Gender"
			};
			layout.Children.Add (Gender, Constraint.Constant (40), Constraint.Constant (140));

			Switch switcher = new Switch {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			layout.Children.Add (switcher, Constraint.Constant (135), Constraint.Constant (140));

			var g = new Label {
				Text = "M"
			};
			layout.Children.Add (g, Constraint.Constant (210), Constraint.Constant (140));
			switcher.Toggled += (sender, e) => {
				if (switcher.IsToggled) {
					g.Text = "F";
				} else if (!(switcher.IsToggled)) {
					g.Text = "M";
				}

			};


			var datePicker = new DatePicker ();
			layout.Children.Add (datePicker, Constraint.Constant (75), Constraint.Constant (190));


			var description = new Entry {
				Placeholder = "Description",
				IsPassword = false,
				BackgroundColor = Color.Gray,
				TextColor = Color.Red
			};
			layout.Children.Add (description, Constraint.Constant (75), Constraint.Constant (240), Constraint.Constant (250), Constraint.Constant (70));

			string[] array = new string[]{ "India", "USA", "China", "Japan" };

			var picker = new Picker (){ BackgroundColor = Color.Yellow, Title = "Country" };
			foreach (string str in array) {
				picker.Items.Add (str);
			}

			layout.Children.Add (picker, Constraint.Constant (140), Constraint.Constant (340), Constraint.Constant (100));


			var selectAImage = new Button { Text = "CaptureImage", TextColor = Color.Black, BackgroundColor = Color.Gray };
			layout.Children.Add (selectAImage, Constraint.Constant (140), Constraint.Constant (400));


			selectAImage.Clicked += (sender, e) => {



			};







			var v = new BoxView {HeightRequest = 1, BackgroundColor = Color.Blue

			};
			layout.Children.Add (v, Constraint.Constant (25), Constraint.Constant (368), Constraint.Constant (320));

			var button = new Button { Text = "Save the Data", TextColor = Color.Black, BackgroundColor = Color.Green };
			layout.Children.Add (button, Constraint.Constant (140), Constraint.Constant (430));


			button.Clicked += (sender, e) => {

				Person personObj = new Person (firstname.Text, g.Text, description.Text, datePicker.Date.ToString (), array [picker.SelectedIndex]);
				database = DependencyService.Get<ISQLite> ().GetConnection ();



				database.CreateTable<Person> ();
				database.Insert (personObj);	
				//			
				//
				//
				var stockList = database.Table<Person> ();
				//		
				//			
				//
				//				this.Navigation.PushAsync(new FootballPlayersListPage(stockList));
				this.Navigation.PushAsync (new FootballPlayerListPage (stockList));
				//this.Navigation.PopAsync (new FootballPlayerListPage (stockList));


			};



			this.Content = layout;


		}
	}
}

