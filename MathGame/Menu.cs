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
		private string name;
		private string menu_choice;
		private string answer;
		private int number1;
		private int number2;
		private int score = 0;
		private List<Game> GameHistory = new List<Game>();

		public void giveMenu()
		{
			Console.WriteLine("Hello, what is your name?");
			name = Console.ReadLine();
			Console.WriteLine($"Welcome, {name}, today is {DateTime.Now.ToString("MM/dd/yyyy")}.");
			Console.WriteLine("---------------------");
			Console.WriteLine();
			math_menu();
		}

		public void AdditionGame()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Addition game!!");
				Random number = new Random();
				number1 = number.Next(0, 20);
				number2 = number.Next(0, 20);
				Console.WriteLine();
				Console.WriteLine($"{number1} + {number2}");
				answer = Console.ReadLine();

				if(answer.Trim().ToLower() == "q")
				{
					GameHistory.Add(new Game
					{
						Score = score,
						Date = DateTime.Now,
						Type = GameType.Addition
					});

					Console.WriteLine("Thank you!!");
					Console.WriteLine();
					Console.WriteLine($"Here is your score, {name}: {score}");
					Console.WriteLine();
					Console.WriteLine("Press Enter to continue...");
					Console.ReadLine();
					Console.Clear();
					math_menu();
				}
				else if(Int32.Parse(answer) == (number1 + number2))
				{
					score++;
					Console.WriteLine("Great, you got it right!!");
					Console.WriteLine();
					Console.WriteLine("Press Enter to continue...");
					Console.ReadLine();
					
				}
				else //if (answer != (number1 + number2))
				{
					Console.WriteLine("Sorry, better luck next time!!");
					Console.WriteLine();
					Console.WriteLine("Press Enter to continue...");
					Console.ReadLine();
					continue;
				}
            }
		}

		public void SubtractionGame()
		{
			Console.Clear();
			Console.WriteLine("Subtraction game!!");

			while (true)
			{
				Random number = new Random();
				number1 = number.Next(0, 20);
				number2 = number.Next(0, 20);
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine($"{number1} - {number2}");
				answer = Console.ReadLine();
				if (answer.Trim().ToLower() == "q")
				{
					GameHistory.Add(new Game
					{
						Score = score,
						Date = DateTime.Now,
						Type = GameType.Subtraction
					});
					Console.WriteLine("Thank you!!");
					Console.WriteLine();
					Console.WriteLine($"Here is your score, {name}: {score}");
					Console.WriteLine();
					Console.WriteLine("Press Enter to continue...");
					Console.ReadLine();
					Console.Clear();
					math_menu();
				}
				else if (Int32.Parse(answer) == (number1 - number2))
				{
					score++;
					Console.WriteLine("Great, you got it right!!");
					Console.WriteLine("Press Enter to continue...");
					Console.ReadLine();
				}
				else //if (answer != (number1 - number2))
				{
					Console.WriteLine("Sorry, better luck next time!!");
					Console.WriteLine();
					Console.WriteLine("Press Enter to continue...");
					Console.ReadLine();
					continue;
				}
			}
		}

		public void MultiplicationGame()
		{
			Console.Clear();
			Console.WriteLine("Multiplication game!!");

			while (true)
			{
				Random number = new Random();
				number1 = number.Next(0, 20);
				number2 = number.Next(0, 20);
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine($"{number1} * {number2}");
				answer = Console.ReadLine();
				if (answer.Trim().ToLower() == "q")
				{
					GameHistory.Add(new Game
					{
						Score = score,
						Date = DateTime.Now,
						Type = GameType.Multiplication
					});
					Console.WriteLine("Thank you!!");
					Console.WriteLine();
					Console.WriteLine($"Here is your score, {name}: {score}");
					Console.WriteLine();
					Console.WriteLine("Press Enter to continue...");
					Console.ReadLine();
					Console.Clear();
					math_menu();
				}
				else if (Int32.Parse(answer) == (number1 * number2))
				{
					score++;
					Console.WriteLine("Great, you got it right!!");
					Console.WriteLine("Press Enter to continue...");
					Console.ReadLine();
				}
				else //if (answer != (number1 * number2))
				{
					Console.WriteLine("Sorry, better luck next time!!");
					Console.WriteLine();
					Console.WriteLine("Press Enter to continue...");
					Console.ReadLine();
					continue;
				}
			}
		}

		public void DivisionGame()
		{
			Console.Clear();
				Console.WriteLine("Division game!!");

				while (true)
				{
					Random number = new Random();
					number1 = number.Next(0, 20);
					number2 = number.Next(0, 20);
					Console.WriteLine();
					Console.WriteLine();
					Console.WriteLine($"{number1} / {number2}");
					answer = Console.ReadLine();
					if (answer.Trim().ToLower() == "q")
					{
						GameHistory.Add(new Game
						{
							Score = score,
							Date = DateTime.Now,
							Type = GameType.Division
						});
					Console.WriteLine("Thank you!!");
					Console.WriteLine();
					Console.WriteLine($"Here is your score, {name}: {score}");
					Console.WriteLine();
					Console.WriteLine("Press Enter to continue...");
					Console.ReadLine();
					Console.Clear();
					math_menu();
				}
					else if (Int32.Parse(answer) == (number1 / number2))
					{
						score++;
						Console.WriteLine("Great, you got it right!!");
						Console.WriteLine("Press Enter to continue...");
						Console.ReadLine();
				}
					else //if (answer != (number1 + number2))
					{
						Console.WriteLine("Sorry, better luck next time!!");
						Console.WriteLine();
						Console.WriteLine("Press Enter to continue...");
						Console.ReadLine();
						continue;
					}
				}
			}

		public void ViewHistory()
		{
			Console.Clear();
			Console.WriteLine($"Here is your history of games, {name}:");
			Console.WriteLine();

			if (GameHistory.Count > 0)
			{
				foreach (var game in GameHistory)
				{
					Console.WriteLine($"{game.Date} -- {game.Type} -- {game.Score}");
				}
			} 
			else
			{
				Console.Clear();
				Console.WriteLine("Sorry, you have no game history yet.");
				Console.WriteLine();
				Console.WriteLine("Press enter to continue...");
				Console.ReadLine();
				Console.Clear();
				math_menu();
			}
		}

		public void math_menu()
		{

			Console.WriteLine("Please choose from the following operations: ");
			Console.WriteLine("A -  Addition");
			Console.WriteLine("S -  Subtraction");
			Console.WriteLine("M -  Multiplication");
			Console.WriteLine("D -  Division");
			Console.WriteLine("V -  View Game History");
			Console.WriteLine("Q -  Quit");
			Console.WriteLine("---------------------");
			Console.WriteLine();

			menu_choice = Console.ReadLine();

			if (menu_choice.Trim().ToLower() == "a")
			{
				AdditionGame();
			}
			else if (menu_choice.Trim().ToLower() == "s")
			{
				SubtractionGame();
			}
			else if (menu_choice.Trim().ToLower() == "m")
			{
				MultiplicationGame();
			}
			else if (menu_choice.Trim().ToLower() == "d")
			{
				DivisionGame();
			}
			else if (menu_choice.Trim().ToLower() == "v")
			{
				ViewHistory();
			}
			else if (menu_choice.Trim().ToLower() == "q")
			{
				Console.WriteLine("Thank you!!  Have a nice day!!");
				Thread.Sleep(2000);
				Environment.Exit(0);
			}
		}
	}
}
