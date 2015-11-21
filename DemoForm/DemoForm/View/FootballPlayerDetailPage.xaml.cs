using System;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;
using System.Diagnostics;

namespace DemoForm
{
	public partial class FootballPlayerDetailPage : ContentPage
	{

		public FootballPlayerDetailPage (object obj)
		{

			InitializeComponent ();

			//this.BindingContext = obj;
			Person myObj = (Person)obj;
			this.FirstNameDetail.Text = myObj.cName;
			this.LastNameDetail.Text = myObj.lName;
			this.DOBDetail.Text = myObj.date.ToString ();
			this.DescriptionDetail.Text = myObj.descriptiondet;



		}
	}
}

