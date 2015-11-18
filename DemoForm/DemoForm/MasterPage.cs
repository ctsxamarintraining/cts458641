using System;
using System.Collections;

using Xamarin.Forms;

namespace DemoForm
{
	public class MasterPage : Xamarin.Forms.MasterDetailPage
	{
		public MasterPage ()
		{


			Label header = new Label {
				Text = "MasterDetailPage",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			string[] array = new string[]{ "ContentPage", "CarouselPage", "TabbedPage" };

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

			this.Detail = new NavigationPage (new MyPage ());


			listView.ItemSelected += (sender, args) => {
				if (listView.SelectedItem.ToString () == "ContentPage") {
					this.Detail = new NavigationPage (new MyPage ());
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
