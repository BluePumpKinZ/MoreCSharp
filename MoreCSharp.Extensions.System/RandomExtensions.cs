using System;

namespace MoreCSharp.Extensions.System {
	public static class RandomExtensions {

		public static DateTime NextDate (this Random random, DateTime maxDate) {
			return random.NextDate (DateTime.MinValue, maxDate);
		}

		public static DateTime NextDate (this Random random, DateTime minDate, DateTime maxDate) {
			long minTicks = minDate.Ticks;
			long maxTicks = maxDate.Ticks;

			return new DateTime (random.NextLong (minTicks, maxTicks));
		}

		public static long NextLong (this Random random) {
			byte[] buffer = new byte[8];
			random.NextBytes (buffer);
			return BitConverter.ToInt64 (buffer, 0) & 0x7FFF_FFFF_FFFF_FFFF;
		}

		public static long NextLong (this Random random, long maxValue) {
			return random.NextLong (0, maxValue);
		}

		public static long NextLong (this Random random, long minValue, long maxValue) {
			if (maxValue < minValue)
				throw new ArgumentException ("Minvalue must be lower or equal to maxvalue", $"{nameof(minValue)}, {nameof(maxValue)}");
			byte[] buffer = new byte[8];
			random.NextBytes (buffer);
			long randomLong = BitConverter.ToInt64 (buffer, 0);
			return Math.Abs (randomLong % (maxValue - minValue)) + minValue;
		}

	}
}
