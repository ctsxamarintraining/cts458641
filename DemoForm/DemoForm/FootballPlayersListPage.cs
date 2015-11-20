using System;
using Xamarin.Forms;
using System.Collections.Generic;
using SQLite;
using System.Diagnostics;

namespace DemoForm
{
	public class FootballPlayersListPage:ContentPage
	{
		public FootballPlayersListPage (TableQuery<Person> personObjects)
		{

			//Debug.WriteLine("the data retrieved is"+ personObjects.ElementAt(0).cName);
			var vetlist = new ListView {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate (typeof(VetCell)),
				ItemsSource = VetData.GetData (personObjects),

				//SeparatorColor = Color.FromHex ("#ddd"),
			};

			var layout = new StackLayout {
				Children = {
					vetlist
				}
			};

			this.Content = layout;
		}





	}


	public class VetCell:ViewCell
	{
		public VetCell ()
		{
			var vetProfileImage = new Image {
				HeightRequest = 50,
				WidthRequest = 50,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
			};
			vetProfileImage.SetBinding (Image.SourceProperty, "ImageSource");

			var nameLabel = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.Black
			};
			nameLabel.SetBinding (Label.TextProperty, "Name");


			var cellLayout = new StackLayout {
				Spacing = 0,
				Padding = new Thickness (10, 5, 10, 5),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { vetProfileImage, nameLabel }
			};

			this.View = cellLayout;



		}


	}

	public class Vet
	{

		public UriImageSource ImageSource { get; set; }

		public string Name { get; set; }

	}

	public static class VetData
	{
		public static List<Vet> GetData (TableQuery<Person> personList)
		{
			List<Vet> list = new List<Vet> ();
			foreach (Person p in personList) {

				list.Add (new Vet () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = p.cName


				});



			}
			return list;

		}
	}
}
