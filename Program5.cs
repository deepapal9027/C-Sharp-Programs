//Write a program odd or even using Method
 
using System;
class Method
{
    static string checkNumber(int num)
	{
		string result;
		if(num%2==0)
			result= "Number is Even";
		else
			result= "Number is odd";
		return result;
	}   
	public static void Main(string[]args)
        {
         string res =  checkNumber(101);
         Console.WriteLine(res);		 
		}
}
/*
  OUTPUT -
 Number is Even

*/
  
  
