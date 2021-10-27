namespace MoreCSharp.System {

	public static class CharExtentions {

		public static string Repeat (this char c, int amount) {
			return new string (c, amount);
		}

	}

}