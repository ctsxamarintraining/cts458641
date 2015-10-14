using System;

namespace Extension2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int? i = null;
			Console.WriteLine (i);
			i = 10;
			Console.WriteLine ("After Assigning the value changes to : {0}",i);

		}
	}
}