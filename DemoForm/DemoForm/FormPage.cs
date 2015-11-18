using System;

using Xamarin.Forms;

namespace DemoForm
{
	public class FormPage : ContentPage
	{
		public FormPage ()
		{
			RelativeLayout layout = new RelativeLayout { Padding = 5 };
			var cname = new Label {
				Text = "Customer Name",
				FontSize = 15,

			};

			layout.Children.Add (cname, Constraint.Constant (90), Constraint.Constant (10));

			var entName = new Entry {
				Placeholder = "Enter Customer Name",
				FontSize = 15,

			};
			layout.Children.Add (entName, Constraint.Constant (90), Constraint.Constant (30));

			var dob = new Label {
				Text = "Date of Birth ",
				FontSize = 13,

			};
			layout.Children.Add (dob, Constraint.Constant (90), Constraint.Constant (80));



			DatePicker datePicker = new DatePicker {
				Format = "D",
				//VerticalOptions = LayoutOptions.CenterAndExpand
			};

			layout.Children.Add (datePicker, Constraint.Constant (90), Constraint.Constant (100));


			var male = new Label {
				Text = "Male",
				FontSize = 17,

			};

			layout.Children.Add (male, Constraint.Constant (50), Constraint.Constant (160));

			Switch switcher = new Switch {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};


			layout.Children.Add (switcher, Constraint.Constant (120), Constraint.Constant (160));


			var female = new Label {
				Text = "Female",
				FontSize = 17,

			};

			layout.Children.Add (female, Constraint.Constant (180), Constraint.Constant (160));

			var MyEditor = new Editor { Text = "Enter your Description",   };

			layout.Children.Add (MyEditor, Constraint.Constant (90), Constraint.Constant (200));


			var button = new Button { Text = "Save", TextColor = Color.Blue };
			layout.Children.Add (button, Constraint.Constant (145), Constraint.Constant (280));

			button.Clicked += (sender, e) => {
				//				
				DisplayAlert ("Validation Error", "Username and Password are required", "Re-try");
				//
				//					
			
				this.Navigation.PushAsync (new MasterPage ());


			};


			this.Content = layout;

		}
	}

}

