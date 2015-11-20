using System;

using Xamarin.Forms;

namespace DemoForm
{
	public class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			RelativeLayout layout = new RelativeLayout { Padding = 10 };
			var label = new Label {
				Text = "LOGIN",
				FontSize = 20 //Device.GetNamedSize (NamedSize.Large, typeof(Label)),

			};

			layout.Children.Add (label, Constraint.Constant (125), Constraint.Constant (5));

			var username = new Entry {
				Placeholder = "Enter Login ID",
				Text = "Prashant"
			};
			layout.Children.Add (username, Constraint.Constant (120), Constraint.Constant (60));

			var password = new Entry { 
				Placeholder = "Password", IsPassword = true, Text = "1234"
			};
			layout.Children.Add (password, Constraint.Constant (125), Constraint.Constant (160));

			var button = new Button { Text = "Log In", TextColor = Color.Blue };
			layout.Children.Add (button, Constraint.Constant (145), Constraint.Constant (235));

			button.Clicked += (sender, e) => {
				if (String.IsNullOrEmpty (username.Text) || String.IsNullOrEmpty (password.Text)) {
					DisplayAlert ("Validation Error", "Username and Password are required", "Re-try");
				
									
				} else if (username.Text == "Prashant" && password.Text == "1234") {

					this.Navigation.PushModalAsync (new MasterPage ());

				}
			};


			this.Content = layout;

		}
	}
}
