using System;

namespace ConsoleAppHello
{
	class HelloCSharp
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("This is me trying CSharp as a novice!");
			System.Console.WriteLine("This is Ifeoluwa getting use to C#!");

			//int age = 27;
			System.Console.Write("Enter your age : ");
			int age = Convert.ToInt16(Console.ReadLine());

			System.Console.WriteLine("I am " + age + " years old");

			DateTime now = DateTime.Now;

			System.Console.WriteLine("The Current Date and Time is : " + now);

			int number = 12345;
			double sqrtNumber = Math.Sqrt(number);
			System.Console.WriteLine("The Square root of 12345 is : " +sqrtNumber);


			System.Console.Write("Enter your age : ");
			int ageten = Convert.ToInt16(Console.ReadLine());
			int tenplus = ageten + 10;
			System.Console.WriteLine("Your age after 10 years is : " +tenplus);
			




			Console.ReadLine();

		}
	}
}
