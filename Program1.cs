//Method Without Parameter and Without Return Type.
 
using System;
class Method
{
    static void process()
        {
         Console.Write("Enter the First no :");
         int first = int.Parse(Console.ReadLine());
 
         Console.Write("Enter the second no :");
         int second = int.Parse(Console.ReadLine());
 
         int result = first+second;
         Console.Write("result is: " +result);
        }
	
   
        
  public static void Main(string[]args)
   {
     process();
 
   }
}