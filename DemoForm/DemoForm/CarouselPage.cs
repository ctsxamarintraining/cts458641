using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoForm
{
	public class CarouselPage : Xamarin.Forms.CarouselPage
	{
		public CarouselPage ()
		{


			List<ContentPage> pages = new List<ContentPage> (0);
			Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Gray, Color.Yellow };
			foreach (Color c in colors) {
				pages.Add (new ContentPage { Content = new StackLayout {
						Children = {
							new Label { Text = "Carousel Demo" },
							new BoxView {
								Color = c,
								VerticalOptions = LayoutOptions.FillAndExpand
							}
						}
					}
				});
			}
			this.Children.Add (pages [0]);
			this.Children.Add (pages [1]);
			this.Children.Add (pages [2]);




		}
	}
}
