using System;

namespace Extension3
{
	class MainClass
	{
		delegate void sampleDelegate(int x);

		public static void Method1(int n)
		{
			Console.WriteLine ("The number is {0}",n);
		}


		public static void Main (string[] args)
		{

			sampleDelegate mydelegate=delegate(int num){
				Console.WriteLine(" anonymous delegate method {0}",num);
			};
			mydelegate(929);

			mydelegate = new sampleDelegate (Method1);
			mydelegate(71);

		}
	}
}