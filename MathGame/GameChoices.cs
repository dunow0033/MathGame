using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MathGame
{
	internal class GameChoices
	{
		private static int number1;
		private static int number2;
		private static int score;
		private static string answer;

		public static void AdditionGame(string name)
		{
			score = 0;

			while (true)
			{
				Console.Clear();
				Random number = new Random();
				number1 = number.Next(0, 20);
				number2 = number.Next(0, 20);
				Console.WriteLine();
				Console.WriteLine($"{number1} + {number2}");
				Console.Write($"Answer ('q' to quit):  ");
				answer = Console.ReadLine();
				var result = Helpers.validateNumber(answer);

				if (answer.Trim().ToLower() == "q")
				{
					Helpers.AddToHistory(score, GameType.Addition);
					Console.WriteLine("Thank you!!");
					Console.WriteLine();
					Console.WriteLine($"Here is your score, {name}: {score}");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
					Console.Clear();
					break;
				}
				else if (Int32.Parse(answer) == (number1 + number2))
				{
					score++;
					Console.WriteLine("Great, you got it right!!");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
				}
				else //if (answer != (number1 + number2))
				{
					Console.WriteLine("Sorry, better luck next time!!");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
				}
			}
		}

		public static void SubtractionGame(string name)
		{
			score = 0;

			while (true)
			{
				Console.Clear();
				Random number = new Random();
				number1 = number.Next(0, 20);
				number2 = number.Next(0, 20);
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine($"{number1} - {number2}");
				Console.Write($"Answer ('q' to quit):  ");
				answer = Console.ReadLine();
				var result = Helpers.validateNumber(answer);

				if (answer.Trim().ToLower() == "q")
				{
					Helpers.AddToHistory(score, GameType.Addition);
					Console.WriteLine("Thank you!!");
					Console.WriteLine();
					Console.WriteLine($"Here is your score, {name}: {score}");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
					Console.Clear();
					break;
				}
				else if (Int32.Parse(answer) == (number1 - number2))
				{
					score++;
					Console.WriteLine("Great, you got it right!!");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
				}
				else
				{
					Console.WriteLine("Sorry, better luck next time!!");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
				}
			}
		}

		public static void MultiplicationGame(string name)
		{
			score = 0;

			while (true)
			{
				Console.Clear();
				Random number = new Random();
				number1 = number.Next(0, 20);
				number2 = number.Next(0, 20);
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine($"{number1} * {number2}");
				Console.Write($"Answer ('q' to quit):  ");
				answer = Console.ReadLine();
				var result = Helpers.validateNumber(answer);

				if (answer.Trim().ToLower() == "q")
				{
					Helpers.AddToHistory(score, GameType.Addition);
					Console.WriteLine("Thank you!!");
					Console.WriteLine();
					Console.WriteLine($"Here is your score, {name}: {score}");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
					Console.Clear();
					break;
				}
				else if (Int32.Parse(answer) == (number1 * number2))
				{
					score++;
					Console.WriteLine("Great, you got it right!!");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
				}
				else
				{
					Console.WriteLine("Sorry, better luck next time!!");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
				}
			}
		}

		public static void DivisionGame(string name)
		{
			score = 0;

			while (true)
			{
				Console.Clear();
				
				var divisionNumbers = Helpers.GetDivisionNumbers();
				var number1 = divisionNumbers[0];
				var number2 = divisionNumbers[1];
				
				Console.WriteLine();
				Console.WriteLine();

				Console.WriteLine($"{number1} / {number2}");
				Console.Write($"Answer ('q' to quit):  ");
				answer = Console.ReadLine();
				var result = Helpers.validateNumber(answer);

				if (answer.Trim().ToLower() == "q")
				{
					Helpers.AddToHistory(score, GameType.Addition);
					Console.WriteLine("Thank you!!");
					Console.WriteLine();
					Console.WriteLine($"Here is your score, {name}: {score}");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
					Console.Clear();
					break;
				}
				else if (Int32.Parse(result) == (number1 / number2))
				{
					score++;
					Console.WriteLine("Great, you got it right!!");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
				}
				else
				{
					Console.WriteLine("Sorry, better luck next time!!");
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
				}
			}
		}
	}
}
