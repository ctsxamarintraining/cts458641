using System;

namespace Exceptionsample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] intArray = new int[10];
			int i = 0;
			do {
				try{
					Console.Write("Please add a number to array : ");
					int ele = Convert.ToInt32(Console.ReadLine());
					intArray[i++] = ele;
					int j = 0;
					string commaSepString = "";
					for(int k=0;k<i; k++){
						if(j==0){
							j++;
							commaSepString = commaSepString+intArray[k];
						}
						else
							commaSepString = commaSepString + "," + intArray[k] ;


					}
					Console.WriteLine("The numbers in the array : "+commaSepString);

				}
				catch(IndexOutOfRangeException e){
					Console.WriteLine(e.Message);
				}
				catch(FormatException e){
					Console.WriteLine(e.Message);
				}
				catch(Exception e){
					Console.WriteLine(e.Message);
				}

			} while(true);
		}
	}
}
