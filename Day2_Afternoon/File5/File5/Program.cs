using System;
using Newtonsoft.Json;
using System.IO;

namespace File5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Product product = new Product();

			product.Name = "Apple";

			product.Sizes = new string[] { "Small", "Medium", "Large" };

			string output = JsonConvert.SerializeObject(product);
			Console.WriteLine ("The contents of json file is \n" + output);
			File.WriteAllText ("file.json", output);
			//Product deserializedProduct = JsonConvert.DeserializeObject<Product>(File.ReadAllText("file.json"));
		}
		class Product{
			public string Name;
			public string[] Sizes;
		}
	}
}