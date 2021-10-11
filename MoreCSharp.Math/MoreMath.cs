namespace MoreCSharp.Math {

	public static class MoreMath {

		// Clamp
		public static byte Clamp (byte v, byte min, byte max) {
			return (v < min) ? ((v > max) ? max : v) : min;
		}

		public static sbyte Clamp (sbyte v, sbyte min, sbyte max) {
			return (v < min) ? ((v > max) ? max : v) : min;
		}

		public static short Clamp (short v, short min, short max) {
			return (v < min) ? ((v > max) ? max : v) : min;
		}

		public static ushort Clamp (ushort v, ushort min, ushort max) {
			return (v < min) ? ((v > max) ? max : v) : min;
		}

		public static int Clamp (int v, int min, int max) {
			return (v < min) ? ((v > max) ? max : v) : min;
		}

		public static uint Clamp (uint v, uint min, uint max) {
			return (v < min) ? ((v > max) ? max : v) : min;
		}

		public static long Clamp (long v, long min, long max) {
			return (v < min) ? ((v > max) ? max : v) : min;
		}

		public static ulong Clamp (ulong v, ulong min, ulong max) {
			return (v < min) ? ((v > max) ? max : v) : min;
		}

		public static float Clamp (float v, float min, float max) {
			return (v < min) ? ((v > max) ? max : v) : min;
		}

		public static double Clamp (double v, double min, double max) {
			return (v < min) ? ((v > max) ? max : v) : min;
		}

		public static decimal Clamp (decimal v, decimal min, decimal max) {
			return (v < min) ? ((v > max) ? max : v) : min;
		}

		// Clamp01
		public static byte Clamp01 (byte v) {
			const byte zero = 0, one = 1;
			return Clamp (v, zero, one);
		}

		public static sbyte Clamp01 (sbyte v) {
			const sbyte zero = 0, one = 1;
			return Clamp (v, zero, one);
		}

		public static short Clamp01 (short v) {
			const short zero = 0, one = 1;
			return Clamp (v, zero, one);
		}

		public static ushort Clamp01 (ushort v) {
			const ushort zero = 0, one = 1;
			return Clamp (v, zero, one);
		}

		public static int Clamp01 (int v) {
			const int zero = 0, one = 1;
			return Clamp (v, zero, one);
		}

		public static uint Clamp01 (uint v) {
			const uint zero = 0, one = 1;
			return Clamp (v, zero, one);
		}

		public static long Clamp01 (long v) {
			const long zero = 0, one = 1;
			return Clamp (v, zero, one);
		}

		public static ulong Clamp01 (ulong v) {
			const ulong zero = 0, one = 1;
			return Clamp (v, zero, one);
		}

		public static float Clamp01 (float v) {
			const float zero = 0, one = 1;
			return Clamp (v, zero, one);
		}

		public static double Clamp01 (double v) {
			const double zero = 0, one = 1;
			return Clamp (v, zero, one);
		}

		public static decimal Clamp01 (decimal v) {
			const decimal zero = 0, one = 1;
			return Clamp (v, zero, one);
		}

		// LerpUnclamped
		public static byte LerpUnclamped (byte a, byte b, double t) {
			return (byte)LerpUnclamped ((double)a, b, t);
		}

		public static sbyte LerpUnclamped (sbyte a, sbyte b, double t) {
			return (sbyte)LerpUnclamped ((double)a, b, t);
		}

		public static short LerpUnclamped (short a, short b, double t) {
			return (short)LerpUnclamped ((double)a, b, t);
		}

		public static ushort LerpUnclamped (ushort a, ushort b, double t) {
			return (ushort)LerpUnclamped ((double)a, b, t);
		}

		public static int LerpUnclamped (int a, int b, double t) {
			return (int)LerpUnclamped ((double)a, b, t);
		}

		public static uint LerpUnclamped (uint a, uint b, double t) {
			return (uint)LerpUnclamped ((double)a, b, t);
		}

		public static long LerpUnclamped (long a, long b, double t) {
			return (long)LerpUnclamped ((double)a, b, t);
		}

		public static ulong LerpUnclamped (ulong a, ulong b, double t) {
			return (ulong)LerpUnclamped ((double)a, b, t);
		}

		public static float LerpUnclamped (float a, float b, float t) {
			return a * (1 - t) + b * t;
		}

		public static double LerpUnclamped (double a, double b, double t) {
			return a * (1 - t) + b * t;
		}

		public static decimal LerpUnclamped (decimal a, decimal b, decimal t) {
			return a * (1 - t) + b * t;
		}

		// Lerp
		public static byte Lerp (byte a, byte b, double t) {
			t = Clamp01 (t);
			return LerpUnclamped (a, b, t);
		}

		public static sbyte Lerp (sbyte a, sbyte b, double t) {
			t = Clamp01 (t);
			return LerpUnclamped (a, b, t);
		}

		public static short Lerp (short a, short b, double t) {
			t = Clamp01 (t);
			return LerpUnclamped (a, b, t);
		}

		public static ushort Lerp (ushort a, ushort b, double t) {
			t = Clamp01 (t);
			return LerpUnclamped (a, b, t);
		}

		public static int Lerp (int a, int b, double t) {
			t = Clamp01 (t);
			return LerpUnclamped (a, b, t);
		}

		public static uint Lerp (uint a, uint b, double t) {
			t = Clamp01 (t);
			return LerpUnclamped (a, b, t);
		}

		public static long Lerp (long a, long b, double t) {
			t = Clamp01 (t);
			return LerpUnclamped (a, b, t);
		}

		public static ulong Lerp (ulong a, ulong b, double t) {
			t = Clamp01 (t);
			return LerpUnclamped (a, b, t);
		}

		public static float Lerp (float a, float b, float t) {
			t = Clamp01 (t);
			return LerpUnclamped (a, b, t);
		}

		public static double Lerp (double a, double b, double t) {
			t = Clamp01 (t);
			return LerpUnclamped (a, b, t);
		}

		public static decimal Lerp (decimal a, decimal b, decimal t) {
			t = Clamp01 (t);
			return LerpUnclamped (a, b, t);
		}

		// Invere Lerp
		public static double InverseLerp (byte a, byte b, byte v) {
			return ((double)v - a) / (b - a);
		}

		public static double InverseLerp (sbyte a, sbyte b, sbyte v) {
			return ((double)v - a) / (b - a);
		}

		public static double InverseLerp (short a, short b, short v) {
			return ((double)v - a) / (b - a);
		}

		public static double InverseLerp (ushort a, ushort b, ushort v) {
			return ((double)v - a) / (b - a);
		}

		public static double InverseLerp (int a, int b, int v) {
			return ((double)v - a) / (b - a);
		}

		public static double InverseLerp (uint a, uint b, uint v) {
			return ((double)v - a) / (b - a);
		}

		public static double InverseLerp (long a, long b, long v) {
			return ((double)v - a) / (b - a);
		}

		public static double InverseLerp (ulong a, ulong b, ulong v) {
			return ((double)v - a) / (b - a);
		}

		public static float InverseLerp (float a, float b, float v) {
			return (v - a) / (b - a);
		}

		public static double InverseLerp (double a, double b, double v) {
			return (v - a) / (b - a);
		}

		public static decimal InverseLerp (decimal a, decimal b, decimal v) {
			return (v - a) / (b - a);
		}

		// Sigmoid
		public static float Sigmoid (float s) {
			return (float)Sigmoid ((double)s);
		}

		public static double Sigmoid (double s) {
			return 1 / (1 + System.Math.Exp (-s));
		}

		public static decimal Sigmoid (decimal s) {
			return (decimal)Sigmoid ((double)s);
		}

	}

}
