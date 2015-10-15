using System;

namespace Flags
{
	class Program
	{

		[FlagsAttribute]
		public enum MyFlags : short
		{
			New= 0x0,
			Foo = 0x1,
			Bar = 0x2,
			Baz = 0x4

		}

		static void Main(string[] args)
		{
			MyFlags fooBar = MyFlags.Foo | MyFlags.Bar|MyFlags.New;
			MyFlags newBar = MyFlags.New;

			if ((fooBar & MyFlags.Foo) == MyFlags.Foo)
			{
				Console.WriteLine("Item has Foo flag set");
			}
			if ((fooBar & MyFlags.Baz) == MyFlags.Baz)
			{
				//this will not be printed
				Console.WriteLine("Item has bar flag set");
			}
			if ((fooBar & MyFlags.New) == MyFlags.New)
			{
				//this will  be printed
				Console.WriteLine("Item has new flag set");
			}
			if ((newBar & MyFlags.New) == MyFlags.New) 
			{
				//this will  be printed

				Console.WriteLine("Item has new flag  again set");

			}

		}
	}
}
