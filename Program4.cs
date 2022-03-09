//Method Without Parameter and With Return Type.
 
using System;
class Method
{
    static int  process()
	{
	 Console.Write("Enter the First no :");
     int first = int.Parse(Console.ReadLine());

     Console.Write("Enter the second no :");
     int second = int.Parse(Console.ReadLine());

     int result = first + second;
	 return result;
    }   
	public static void Main(string[]args)
        {
         int num3 = process();
         Console.Write("Result is :" +num3);		 
		}
}
/*
  OUTPUT -
  Result is :200
  
*/
  
  