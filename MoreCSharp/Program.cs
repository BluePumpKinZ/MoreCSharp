using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreCSharp.Tests {
	public class Program {

		public static void PrintTestLine (string testName, bool passed) {
			Console.ForegroundColor = passed ? ConsoleColor.Green : ConsoleColor.Red;
			Console.WriteLine ($"{testName, -25} | {(passed ? "Passed" : "Failed")}");
			Console.ResetColor ();
		}

		public static bool CheckLists<T> (IEnumerable<T> a, IEnumerable<T> b) {
			if (a.LongCount () != b.LongCount ())
				return false;
			foreach (Tuple<T, T> tuple in a.Zip (b, (first, second) => new Tuple<T, T> (first, second))) {
				if (!Equals (tuple.Item1, tuple.Item2))
					return false;
			}

			return true;
		}

		public static void Main () {

			new LongListTest ().Test ();

		}
	}
}
