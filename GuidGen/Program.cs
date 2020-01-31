using System;

namespace GuidGen
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.White;
			PrintInfo();

			Console.ForegroundColor = ConsoleColor.DarkCyan;
			PrintPrompt();

			Console.ForegroundColor = ConsoleColor.Cyan;

			var upperCase = true;

			var input = Console.ReadLine().ToLower();

			while (input != "exit")
			{
				if (input == "help")
				{
					Console.ForegroundColor = ConsoleColor.White;
					PrintHelp();
					Console.ForegroundColor = ConsoleColor.Cyan;
				}
				else if (input == "clear")
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.White;
					PrintInfo();
				}
				else if (input == "upper")
				{
					upperCase = true;
				}
				else if (input == "lower")
				{
					upperCase = false;
				}
				else if (Int32.TryParse(input, out var numOfGuidToGenerate))
				{
					for (int i = 0; i < numOfGuidToGenerate; i++)
					{
						Console.WriteLine();
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine($"{i + 1})");
						Console.ForegroundColor = ConsoleColor.White;
						var guidString = upperCase ? Guid.NewGuid().ToString().ToUpper() : Guid.NewGuid().ToString().ToLower();
						Console.WriteLine(guidString);
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine();
					}
				}
				else if (input == "")
				{
					// do nothing
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;

					Console.WriteLine($"Error: invalid command {input}");

					Console.ForegroundColor = ConsoleColor.Cyan;
				}

				Console.ForegroundColor = ConsoleColor.DarkCyan;
				PrintPrompt();
				Console.ForegroundColor = ConsoleColor.Cyan;

				input = Console.ReadLine();
			}
		}

		private static void PrintInfo()
		{
			Console.WriteLine("**************************************");
			Console.WriteLine("*                                    *");
			Console.WriteLine("* This is a beautiful Guid generator *");
			Console.WriteLine("*                                    *");
			Console.WriteLine("* Enter \"help\" to see help info      *");
			Console.WriteLine("*                                    *");
			Console.WriteLine("**************************************");
			Console.WriteLine();
		}

		private static void PrintPrompt()
		{
			Console.Write("GuidGen$: ");
		}

		private static void PrintHelp()
		{
			Console.WriteLine();
			Console.WriteLine(" -- enter any number to generate {x} number of Guid you want to generate");
			Console.WriteLine();
			Console.WriteLine(" -- enter \"clear\" to clean up this beautiful app");
			Console.WriteLine();
			Console.WriteLine(" -- enter \"exit\" to exit the this beautiful app");
			Console.WriteLine();
			Console.WriteLine();
		}
	}
}
