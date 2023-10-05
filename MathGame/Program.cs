using System;
using MathGame;
using System.Diagnostics;
using System.Xml.Linq;

//class Program
//{
//	static void Main(string[] args)
//	{

		string name = Helpers.GetName();

		Console.Clear();

		Menu menu = new Menu();
		menu.ShowMenu(name);
//	}
//}
