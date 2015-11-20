using System;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using System.Diagnostics;


namespace DemoForm
{

	public class Person
	{
		[PrimaryKey,AutoIncrement]
		public int key{ get; set; }

		public Person ()
		{



		}

		public string cName{ get; set; }

		public string gender{ get; set; }

		public string country{ get; set; }

		public string date{ get; set; }

		public string descriptiondet{ get; set; }



		public Person (string customerName, string customerGender, string description, string dateSelected, string countrySelected)
		{
			cName = customerName;
			gender = customerGender;
			date = dateSelected;
			descriptiondet = description;
		}
	}
}
