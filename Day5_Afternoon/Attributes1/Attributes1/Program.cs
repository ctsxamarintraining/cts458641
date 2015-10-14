#define CONDITION
#define RELEASE

using System; 
using System.Diagnostics; 

class MainClass { 

	[Conditional("CONDITION")]  
	void con() { 
		Console.WriteLine("Only if condition is defined, will this sentence appear on the screen "); 
	} 

	[Conditional("RELEASE")]  
	void release() { 
		Console.WriteLine("Final release version."); 
	} 

	public static void Main() { 
		MainClass t = new MainClass(); 

		t.con(); // call only if TRIAL is defined 
		t.release(); // called only if RELEASE is defined 
	} 
}