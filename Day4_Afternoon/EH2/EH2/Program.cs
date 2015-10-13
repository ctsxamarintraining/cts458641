using System;

namespace ExceptionsEx1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//			Write a program that reads an integer number and calculates and prints its square root. 
			//			If the number is invalid or negative, print "Invalid number”. In all cases finally print "Goodbye". " +
			//				"Use try-catch-finally.
			try{
				int number;
				Console.Write ("Enter a number : ");
				number = Convert.ToInt32 (Console.ReadLine ());
				if(number < 0)
					throw new NegativeNumberException("Invalid number");
				Console.WriteLine("The square root of "+number+" is " +Math.Sqrt(number));
			}
			catch(FormatException e){
				Console.WriteLine ("Invalid number");
			}
			catch(NegativeNumberException e){
				Console.WriteLine (e.Message);
			}
			catch(Exception e){
				Console.WriteLine ("Invalid number");
			}
			finally{
				Console.WriteLine ("Goodbye");
			}

		}
		class NegativeNumberException:ApplicationException
		{
			public NegativeNumberException(string message):base(message){
				//				Console.WriteLine("Use positive numbers only");
			}
			// show message
		}

	}
}