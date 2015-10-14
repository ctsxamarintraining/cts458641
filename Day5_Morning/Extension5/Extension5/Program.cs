using System;

namespace Extension5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			partialClassDemo pc = new partialClassDemo ();
			pc.printString ();
			pc.printNum ();

		}


	}
}
namespace Extension5
{
	public partial class partialClassDemo
	{
		public void printNum()
		{
			int i = 3710;
			int j = 110;
			int h = i + j;
			Console.WriteLine ("The total: {0}", h);
		}
	}

	public partial class partialClassDemo
	{
		public void printString()
		{
			string str = "Prashant";
			Console.WriteLine ("The string is {0}", str);
		}

	}
}