using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DemoForm
{
	public partial class FootballPlayerListPage2 : ContentPage
	{
		public FootballPlayerListPage2 ()
		{
			this.BindingContext = new FootballPlayerListViewModel ();
			InitializeComponent ();
		}
	}
}

