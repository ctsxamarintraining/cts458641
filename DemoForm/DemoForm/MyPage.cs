using System;

using Xamarin.Forms;

namespace DemoForm
{
	public class MyPage : ContentPage
	{
		public MyPage ()
		{
			RelativeLayout stack = new RelativeLayout ();
			var myImage = new Image { Source = "img.jpg", Opacity = 0.5 };

			stack.Children.Add (myImage, 
				Constraint.Constant (0), 
				Constraint.Constant (0),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width;
				}),
				Constraint.RelativeToParent ((parent) => {
					return parent.Height;
				}));

			
			var button = new Button { Text = "FORM", BackgroundColor = Color.Blue, TextColor = Color.Black };
			stack.HorizontalOptions = LayoutOptions.Center;
			stack.VerticalOptions = LayoutOptions.Center;

//			stack.Children.Add (myImage, Constraint.Constant (0), Constraint.Constant (0));
			stack.Children.Add (button, Constraint.Constant (140), Constraint.Constant (250));


			button.Clicked += (sender, e) => {
				this.Navigation.PushAsync (new FormPage ());
			};

			this.Content = stack;




		}
	}
}

