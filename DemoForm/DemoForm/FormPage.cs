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
				Text = "Add a Legend",
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
				Placeholder = "Enter the Last Name"
			};
			layout.Children.Add (lastname, Constraint.Constant (135), Constraint.Constant (100));

			var dob = new Label {
				Text = "Date of Birth"
			};
			layout.Children.Add (dob, Constraint.Constant (40), Constraint.Constant (140));

				
			var datePicker = new DatePicker ();
			string format = "d MMM, yyyy";
			layout.Children.Add (datePicker, Constraint.Constant (135), Constraint.Constant (140));


			var description = new Entry {
				Placeholder = "Description",
				IsPassword = false,
				BackgroundColor = Color.Gray,
				TextColor = Color.Red
			};
			layout.Children.Add (description, Constraint.Constant (65), Constraint.Constant (170), Constraint.Constant (250), Constraint.Constant (70));


			var cntry = new Label {
				Text = "Country"
			};
			layout.Children.Add (cntry, Constraint.Constant (35), Constraint.Constant (250));


			string[] array = new string[]{ "India", "USA", "Belgium", "Brazil", "England", "Spain" };

			var picker = new Picker (){ Title = "Country" };
			foreach (string str in array) {
				picker.Items.Add (str);
			}

			layout.Children.Add (picker, Constraint.Constant (140), Constraint.Constant (250), Constraint.Constant (100));


//			var selectAImage = new Button { Text = "CaptureImage", TextColor = Color.Black, BackgroundColor = Color.Gray };
//			layout.Children.Add (selectAImage, Constraint.Constant (140), Constraint.Constant (320));
//
//
//			selectAImage.Clicked += (sender, e) => {
//
//
//
//			};
				
			var v = new BoxView {HeightRequest = 1, BackgroundColor = Color.Black

			};
			layout.Children.Add (v, Constraint.Constant (25), Constraint.Constant (368), Constraint.Constant (320));

			var button = new Button { Text = "Save the Data", TextColor = Color.Black };
			layout.Children.Add (button, Constraint.Constant (140), Constraint.Constant (430));


			button.Clicked += (sender, e) => {


				Person personObj = new Person (firstname.Text, lastname.Text, array [picker.SelectedIndex], datePicker.Date.ToString (format), description.Text, false);
										
				

				database = DependencyService.Get<ISQLite> ().GetConnection ();



				database.CreateTable<Person> ();
				database.Insert (personObj);	

				var stockList = database.Table<Person> ();

				this.Navigation.PushAsync (new FootballPlayerListPage (stockList));

						

			};



			this.Content = layout;

		
		}
	}
}
