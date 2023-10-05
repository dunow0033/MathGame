﻿using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MathGame
{
	internal class Helpers
	{
		internal static List<Game> gameHistory = new();

		internal static void AddToHistory(int gameScore, GameType gameType)
		{
			gameHistory.Add(new Game
			{
				Date = DateTime.Now,
				Score = gameScore,
				Type = gameType
			});
		}

		internal static void PrintGames(string name)
		{
			Console.Clear();

			if (gameHistory.Count > 0)
			{
				Console.WriteLine("Games History");
				Console.WriteLine("--------------------");
				foreach (var game in gameHistory)
				{

					Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} points");
				}
				Console.WriteLine("--------------------\n");
				Console.WriteLine("Press any key to return to main menu");
				Console.ReadKey();
				Console.Clear();
			}
			else
			{
				Console.WriteLine($"Sorry {name}, you have no game history yet");
				Console.WriteLine("Press any key to return to main menu");
				Console.ReadKey();
				Console.Clear();
			}
		}

		internal static string GetName() 
		{
			Console.WriteLine("Hello, what is your name?");
			var name = Console.ReadLine();

			while(!Regex.IsMatch(name, "^[a-zA-Z]+$"))
			{
				Console.WriteLine("Sorry, name should only be letters.  Please try again:");
				name = Console.ReadLine();
			}
			
			while(string.IsNullOrEmpty(name))
			{
				Console.WriteLine("Sorry, name must not be empty.  Please try again:");
				name = Console.ReadLine();
			}

			name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

			return name;
		}
	}
}
