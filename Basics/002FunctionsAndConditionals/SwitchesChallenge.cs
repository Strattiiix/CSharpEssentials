using System;

public class Lab01b
{
    public void Main()
	{
		number(91);
		gradeChecker("Math");
		compare(-2);
		
		
	}
	
	public void gradeChecker (string subject) {
		if(subject == "Math") {
			Console.WriteLine("Keep memorizing your times tables");
		}
		if(subject == "Science") {
			Console.WriteLine("Always wear your saftey goggles when working on your science fair project!");
		}
		if(subject == "English") {
			Console.WriteLine("Keep up todate with your reading log and vocabulary words");
		}
		if(subject == "History") {
			Console.WriteLine("Your projects on a US president are due next week!");
		}
		if(subject == "PE") {
			Console.WriteLine("Tomorrow is Dodgeball! Bring good shoes");
		}
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
		if(value > 37)
		{
		 	Console.WriteLine("Triple Digits today, You may melt, better stay in side!");
		}
		else if(number > 30)
		{
			Console.WriteLine("The sun is out! Time to get a tan!");
		}
		else if(number > 21)
		{
			Console.WriteLine("What a beautiful day for stroll in the park!");
		}
		else if(number > 10)
		{
			Console.WriteLine("Tis a bit nippy out there.");
		}
		else if(number > 0)
		{
			Console.WriteLine("Winter is coming");
		}
		else if(number < 0) 
		{
			Console.WriteLine("Don't lick any telephone polls Flick!");
		}
	}
}
