//Method With Parameter and With Return Type.
 
using System;
class Method
{
    static int process(int first,int second)
        {
		 int result = first+second;
          return result;		 
         
        }
	public static void Main(string[]args)
       {
            Console.Write("Enter the First no :");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter the second no :");
            int second = int.Parse(Console.ReadLine());

            int num3 =process(first,second);
            Console.Write("result is: " + num3);
			
		}
}
/*
  OUTPUT -
  Enter the First no :6
  Enter the second no :2
  result is:8
  
  */
  
  
