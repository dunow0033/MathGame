using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathGame
{
	class Menu
	{
		private string answer;
		private int number1;
		private int number2;
		private int score = 0;
		//private List<Game> GameHistory = new List<Game>();

		//public void giveMenu()
		//{
		//	
		//	Console.WriteLine($"Welcome, {name}, today is {DateTime.Now.ToString("MM/dd/yyyy")}.");
		//	Console.WriteLine("---------------------");
		//	Console.WriteLine();
		//	math_menu();
		//}

		internal void ShowMenu(string name)
		{
			var isGameOn = true;
			do
			{
				Console.WriteLine("------------------------------");
				Console.WriteLine($"Hello {name}. It's {DateTime.Now.ToString("MM/dd/yyyy")}. This is your math game.\n");
				Console.WriteLine("Press any key to show menu");
				Console.ReadKey();
				Console.Clear();
				Console.WriteLine($@"Please choose a subject:
    V - View Previous Games
    A - Addition
    S - Subtraction
    M - Multiplication
    D - Division
    Q - Quit the program");
				Console.WriteLine("------------------------------");

				var gameSelected = Console.ReadLine();

				switch (gameSelected.Trim().ToLower())
				{
					case "v":
						Helpers.PrintGames(name);
						break;
					case "a":
						AdditionGame(name);
						break;
					case "s":
						SubtractionGame(name);
						break;
					case "m":
						//MultiplicationGame("Multiplication game");
						break;
					case "d":
						//DivisionGame("Division game");
						break;
					case "q":
						Console.Write("Goodbye");
						isGameOn = false;
						Environment.Exit(1);
						break;
					default:
						Console.WriteLine("Invalid input");
						break;
				}
			}
			while (isGameOn);
		}

		

		

		//		public void MultiplicationGame()
		//		{

		//			while (true)
		//			{
		//				Console.Clear();
		//				Random number = new Random();
		//				number1 = number.Next(0, 20);
		//				number2 = number.Next(0, 20);
		//				Console.WriteLine();
		//				Console.WriteLine();
		//				Console.WriteLine($"{number1} * {number2}");
		//				answer = Console.ReadLine();

		//				if (answer.Trim().ToLower() == "q")
		//				{
		//					GameHistory.Add(new Game
		//					{
		//						Score = score,
		//						Date = DateTime.Now,
		//						Type = GameType.Multiplication
		//					});
		//					Console.WriteLine("Thank you!!");
		//					Console.WriteLine();
		//					Console.WriteLine($"Here is your score, {name}: {score}");
		//					Console.WriteLine();
		//					Console.WriteLine("Press any key to continue...");
		//					Console.ReadKey();
		//					Console.Clear();
		//					math_menu();
		//				}
		//				else if (Int32.Parse(answer) == (number1 * number2))
		//				{
		//					score++;
		//					Console.WriteLine("Great, you got it right!!");
		//					Console.WriteLine("Press any key to continue...");
		//					Console.ReadKey();
		//				}
		//				else //if (answer != (number1 * number2))
		//				{
		//					Console.WriteLine("Sorry, better luck next time!!");
		//					Console.WriteLine();
		//					Console.WriteLine("Press any key to continue...");
		//					Console.ReadKey();
		//					continue;
		//				}
		//			}
		//		}

		//		public void DivisionGame()
		//		{
		//			while (true)
		//			{
		//				Console.Clear();
		//				Random number = new Random();
		//					number1 = number.Next(0, 20);
		//					number2 = number.Next(0, 20);
		//					Console.WriteLine();
		//					Console.WriteLine();
		//					Console.WriteLine($"{number1} / {number2}");
		//					answer = Console.ReadLine();

		//					if (answer.Trim().ToLower() == "q")
		//					{
		//						GameHistory.Add(new Game
		//						{
		//							Score = score,
		//							Date = DateTime.Now,
		//							Type = GameType.Division
		//						});
		//					Console.WriteLine("Thank you!!");
		//					Console.WriteLine();
		//					Console.WriteLine($"Here is your score, {name}: {score}");
		//					Console.WriteLine();
		//					Console.WriteLine("Press any key to continue...");
		//					Console.ReadKey();
		//					Console.Clear();
		//					math_menu();
		//				}
		//					else if (Int32.Parse(answer) == (number1 / number2))
		//					{
		//						score++;
		//						Console.WriteLine("Great, you got it right!!");
		//						Console.WriteLine("Press any key to continue...");
		//						Console.ReadKey();
		//				}
		//					else //if (answer != (number1 + number2))
		//					{
		//						Console.WriteLine("Sorry, better luck next time!!");
		//						Console.WriteLine();
		//						Console.WriteLine("Press any key to continue...");
		//						Console.ReadKey();
		//						continue;
		//					}
		//				}
		//			}

		//		public void ViewHistory()
		//		{
		//			Console.Clear();
		//			Console.WriteLine($"Here is your history of games, {name}:");
		//			Console.WriteLine();

		//			if (GameHistory.Count > 0)
		//			{
		//				foreach (var game in GameHistory)
		//				{
		//					Console.WriteLine($"{game.Date} -- {game.Type} -- {game.Score}");
		//				}
		//			} 
		//			else
		//			{
		//				Console.Clear();
		//				Console.WriteLine("Sorry, you have no game history yet.");
		//				Console.WriteLine();
		//				Console.WriteLine("Press any key to continue...");
		//				Console.ReadKey();
		//				Console.Clear();
		//				math_menu();
		//			}
		//		}
		//	}
		//}

	}

}
