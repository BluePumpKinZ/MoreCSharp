using System;

namespace MoreCSharp.Tests {
	public class Program {

		public static void PrintTestLine (string testName, bool passed) {
			Console.ForegroundColor = passed ? ConsoleColor.Green : ConsoleColor.Red;
			Console.WriteLine ($"{testName, -25} | {(passed ? "Passed" : "Failed")}");
			Console.ResetColor ();
		}

		public static void Main () {

			new LongListTest ().Test ();

		}
	}
}
