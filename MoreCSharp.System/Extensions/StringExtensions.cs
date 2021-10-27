using System;

namespace MoreCSharp.System {

	public static class StringExtensions {

		public static string Repeat (this string str, int amount) {
			if (str == "")
				return "";
			if (amount < 0)
				throw new ArgumentException ("Amount cannot be negative", nameof (amount));
			if (str.Length * (long)amount > int.MaxValue)
				throw new OverflowException ("The resulting string is too big");

			int length = str.Length * amount;

			Span<char> resultSpan = length <= 128 ? stackalloc char[length] : new char[length];

			int strLength = str.Length;
			
			for (int i = 0; i < amount; i++) {
				for (int j = 0; j < strLength; j++) {
					int offset = i * strLength;
					resultSpan[offset + j] = str[j];
				}
			}

			return new string (resultSpan);
		}

	}

}