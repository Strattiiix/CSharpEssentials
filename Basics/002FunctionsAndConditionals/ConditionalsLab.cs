using System;

public class Lab01b
{
    public void Main()
	{
		number(91);
		compare(31);
	}
     public void number (int value) {
		 var number = value;
		if(value > 90)
		{
		 	Console.WriteLine("Your Grade is an A");
		}
		else if(number > 80)
		{
			Console.WriteLine("Your Grade is a B");
		}
		else if(number > 70)
		{
			Console.WriteLine("Your Grade is a C");
		}
		else if(number > 60)
		{
			Console.WriteLine("Your Grade is a D");
		}
		else if(number > 50)
		{
			Console.WriteLine("Your Grade is a F");
		}
	
	 }
	 public void compare (int value) {
		 var number = value;
		if(value > 30) 
		{
			Console.WriteLine("Make sure to stay hydrated and avoid staying in the sun for too long");
		}
      	if(value < 30)
		{
			Console.WriteLine("Today is a great day to be outside");
		}
	}
}
