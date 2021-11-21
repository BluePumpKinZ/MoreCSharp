using System;

namespace MoreCSharp.Extensions.System {
	public static class RandomExtensions {

		public static DateTime NextDate (this Random random, DateTime maxDate) {
			return random.NextDate (DateTime.MinValue, maxDate);
		}

		public static DateTime NextDate (this Random random, DateTime minDate, DateTime maxDate) {
			long minTicks = minDate.Ticks;
			long maxTicks = maxDate.Ticks;

			return new DateTime (random.Next (minTicks, maxTicks));
		}

		public static long Next (this Random random, long maxValue) {
			return random.Next (0, maxValue);
		}

		public static long Next (this Random random, long minValue, long maxValue) {
			if (maxValue < minValue)
				throw new ArgumentException ("Minvalue must be lower or equal to maxvalue", $"{nameof(minValue)}, {nameof(maxValue)}");
			byte[] buffer = new byte[8];
			random.NextBytes (buffer);
			long randomLong = BitConverter.ToInt64 (buffer, 0);
			return Math.Abs (randomLong % (maxValue - minValue)) + minValue;
		}

	}
}
