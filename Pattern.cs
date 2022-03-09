// loop
using System;
class while_loop
{
	static void Main(string[]args)
    {
      int ctr=0;
      int ptr;
      while(ctr<4)
      {
        ptr=0;
     while(ptr<4)
       {
	Console.Write("*");
         ptr=ptr=ptr+1;			
       }
      Console.WriteLine();
      ctr=ctr+1;
     }
    }   
}
 
 /* OUTPUT-
   * * * *
   * * * *
   * * * *
   * * * *
   
 */
 

  
  
