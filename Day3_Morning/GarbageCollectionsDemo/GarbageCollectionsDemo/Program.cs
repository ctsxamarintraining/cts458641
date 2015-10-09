using System;

namespace GarbageCollectionsDemo
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			long mem1 = GC.GetTotalMemory(false);
			//GC.Collect();
			Console.WriteLine(mem1);
			int[] values = new int[500000];

			values = null;
			long mem2 = GC.GetTotalMemory(false);
			Console.WriteLine(mem2);
			GC.Collect();
			long mem3 = GC.GetTotalMemory(false);
			Console.WriteLine(mem3);



		}
	}
}
