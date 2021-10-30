using MoreCSharp.Extensions.System;
using System.Collections.Generic;

namespace MoreCSharp.Tests {

	public class StringExtensions {

		public void Test () {

			string result, expected;
			List<bool> results = new List<bool> ();

			result = "a".Repeat (5);
			expected = "aaaaa";
			results.Add (result == expected);

			result = "abc".Repeat (3);
			expected = "abcabcabc";
			results.Add (result == expected);

			Program.PrintTestLine ("Repeating strings", !results.Contains (false));

		}

	}

}
