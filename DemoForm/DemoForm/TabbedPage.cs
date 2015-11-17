using System;

using Xamarin.Forms;

namespace XamarinForms1
{
	public class TabbedPage : Xamarin.Forms.TabbedPage
	{
		public TabbedPage ()
		{
			//		

			this.Title = "TabbedPage";
			this.Children.Add (new ContentPage {
				Title = "Blue and Red",

				Content = new StackLayout {
					Children = {
						new Label { Text = "Gray and Green" },
						new BoxView { Color = Color.Gray },
						new BoxView { Color = Color.Green }
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "Blue and Red",

				Content = new StackLayout {
					Children = {
						new Label { Text = "Blue and Red" },
						new BoxView { Color = Color.Blue },
						new BoxView { Color = Color.Red }
					}
				}
			});


			this.Children.Add (new ContentPage {
				Title = "Blue and Red",

				Content = new StackLayout {
					Children = {
						new Label { Text = "Yellow and Gray" },
						new BoxView { Color = Color.Yellow },
						new BoxView { Color = Color.Gray }
					}
				}
			});

			this.Children.Add (new ContentPage {
				Title = "Blue and Red",

				Content = new StackLayout {
					Children = {
						new Label { Text = "Gray and Green" },
						new BoxView { Color = Color.Gray },
						new BoxView { Color = Color.Green }
					}
				}
			});

		}
	}
}
