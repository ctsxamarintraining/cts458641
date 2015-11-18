using System;

using Xamarin.Forms;

namespace DemoForm
{
	public class SingleTappedPage : ContentPage
	{
		public SingleTappedPage (int index)
		{
			if (index == 0) {
				Content = new StackLayout { 
					Children = {
						new Label { Text = " Gray" },
						new BoxView { Color = Color.Gray,
							VerticalOptions = LayoutOptions.FillAndExpand
						},
					}
				};
			}




			if (index == 1) {
				Content = new StackLayout { 

					Children = {
						new Label { Text = "Blue" },
						new BoxView { Color = Color.Blue,
							VerticalOptions = LayoutOptions.FillAndExpand
						},
					}
				};
			}



			if (index == 2) {
				Content = new StackLayout { 
					Children = {
						new Label { Text = "Red" },
						new BoxView { Color = Color.Red,
							VerticalOptions = LayoutOptions.FillAndExpand
						},
					}
				};
			}



			if (index == 3) {
				Content = new StackLayout { 
					Children = {
						new Label { Text = "Green" },
						new BoxView { Color = Color.Green,
							VerticalOptions = LayoutOptions.FillAndExpand
						},
					}
				};
			}

		}
	}
}
