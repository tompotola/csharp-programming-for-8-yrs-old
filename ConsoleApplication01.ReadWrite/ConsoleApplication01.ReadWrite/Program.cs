using System;

namespace ConsoleApplication01.ReadWrite
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			string string_name = "Jana";
			string string_greeting = "Bok";
			*/

			// Console.WriteLine (string_name + " " + string_greeting + "!");
			// Console.WriteLine (string_greeting + " " + string_name + "!");

			Console.Write ("What is your name?");
			string line = Console.ReadLine ();

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("Hi " + line);

			Console.WriteLine ("Hi " + line.ToLower());
			return;
		}
	}
}
