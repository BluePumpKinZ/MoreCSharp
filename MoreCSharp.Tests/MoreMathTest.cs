using System.Collections.Generic;
using MoreCSharp.Math;

namespace MoreCSharp.Tests {

	public class MoreMathTest {

		public void Test () {

			// Clamp
			byte[][] dataBytes = new byte[][]
			{
				new byte[] { 1, 3, 4, 3 },
				new byte[] { 2, 3, 5, 3 },
				new byte[] { 2, 4, 1, 2 },
				new byte[] { 3, 7, 2, 3 },
				new byte[] { 2, 3, 5, 3 },
				new byte[] { 0, 9, 5, 5 },
			};

			sbyte[][] dataSBytes = new sbyte[][]
			{
				new sbyte[] { 1, 3, 4, 3 },
				new sbyte[] { 2, 3, 5, 3 },
				new sbyte[] { 2, 4, 1, 2 },
				new sbyte[] { 3, 7, 2, 3 },
				new sbyte[] { 2, 3, 5, 3 },
				new sbyte[] { 0, 9, 5, 5 },
			};

			short[][] dataShorts = new short[][]
			{
				new short[] { 1, 3, 4, 3 },
				new short[] { 2, 3, 5, 3 },
				new short[] { 2, 4, 1, 2 },
				new short[] { 3, 7, 2, 3 },
				new short[] { 2, 3, 5, 3 },
				new short[] { 0, 9, 5, 5 },
			};

			ushort[][] dataUShorts = new ushort[][]
			{
				new ushort[] { 1, 3, 4, 3 },
				new ushort[] { 2, 3, 5, 3 },
				new ushort[] { 2, 4, 1, 2 },
				new ushort[] { 3, 7, 2, 3 },
				new ushort[] { 2, 3, 5, 3 },
				new ushort[] { 0, 9, 5, 5 },
			};

			int[][] dataInts = new int[][]
			{
				new int[] { 1, 3, 4, 3 },
				new int[] { 2, 3, 5, 3 },
				new int[] { 2, 4, 1, 2 },
				new int[] { 3, 7, 2, 3 },
				new int[] { 2, 3, 5, 3 },
				new int[] { 0, 9, 5, 5 },
			};

			uint[][] dataUInts = new uint[][]
			{
				new uint[] { 1, 3, 4, 3 },
				new uint[] { 2, 3, 5, 3 },
				new uint[] { 2, 4, 1, 2 },
				new uint[] { 3, 7, 2, 3 },
				new uint[] { 2, 3, 5, 3 },
				new uint[] { 0, 9, 5, 5 },
			};

			long[][] dataLongs = new long[][]
			{
				new long[] { 1, 3, 4, 3 },
				new long[] { 2, 3, 5, 3 },
				new long[] { 2, 4, 1, 2 },
				new long[] { 3, 7, 2, 3 },
				new long[] { 2, 3, 5, 3 },
				new long[] { 0, 9, 5, 5 },
			};

			ulong[][] dataULongs = new ulong[][]
			{
				new ulong[] { 1, 3, 4, 3 },
				new ulong[] { 2, 3, 5, 3 },
				new ulong[] { 2, 4, 1, 2 },
				new ulong[] { 3, 7, 2, 3 },
				new ulong[] { 2, 3, 5, 3 },
				new ulong[] { 0, 9, 5, 5 },
			};

			float[][] dataSingels = new float[][]
			{
				new float[] { 1, 3, 4, 3 },
				new float[] { 2, 3, 5, 3 },
				new float[] { 2, 4, 1, 2 },
				new float[] { 3, 7, 2, 3 },
				new float[] { 2, 3, 5, 3 },
				new float[] { 0, 9, 5, 5 },
			};

			double[][] dataDoubles = new double[][]
			{
				new double[] { 1, 3, 4, 3 },
				new double[] { 2, 3, 5, 3 },
				new double[] { 2, 4, 1, 2 },
				new double[] { 3, 7, 2, 3 },
				new double[] { 2, 3, 5, 3 },
				new double[] { 0, 9, 5, 5 },
			};

			decimal[][] dataDecimals = new decimal[][]
			{
				new decimal[] { 1, 3, 4, 3 },
				new decimal[] { 2, 3, 5, 3 },
				new decimal[] { 2, 4, 1, 2 },
				new decimal[] { 3, 7, 2, 3 },
				new decimal[] { 2, 3, 5, 3 },
				new decimal[] { 0, 9, 5, 5 },
			};

			List<byte> aListBytes = new List<byte> (), bListBytes = new List<byte> ();
			for (int i = 0; i < dataBytes.Length; i++) {
				aListBytes.Add (MoreMath.Clamp (dataBytes[i][2], dataBytes[i][0], dataBytes[i][1]));
				bListBytes.Add (dataBytes[i][3]);
			}

			Program.PrintTestLine ("Clamp Bytes", Program.CheckLists (aListBytes, bListBytes));

			List<sbyte> aListSBytes = new List<sbyte> (), bListSBytes = new List<sbyte> ();
			for (int i = 0; i < dataBytes.Length; i++) {
				aListSBytes.Add (MoreMath.Clamp (dataSBytes[i][2], dataSBytes[i][0], dataSBytes[i][1]));
				bListSBytes.Add (dataSBytes[i][3]);
			}

			Program.PrintTestLine ("Clamp SBytes", Program.CheckLists (aListSBytes, bListSBytes));

			List<short> aListShorts = new List<short> (), bListShorts = new List<short> ();
			for (int i = 0; i < dataShorts.Length; i++) {
				aListShorts.Add (MoreMath.Clamp (dataShorts[i][2], dataShorts[i][0], dataShorts[i][1]));
				bListShorts.Add (dataBytes[i][3]);
			}

			Program.PrintTestLine ("Clamp Shorts", Program.CheckLists (aListShorts, bListShorts));

			List<ushort> aListUShorts = new List<ushort> (), bListUShorts = new List<ushort> ();
			for (int i = 0; i < dataUShorts.Length; i++) {
				aListUShorts.Add (MoreMath.Clamp (dataUShorts[i][2], dataUShorts[i][0], dataUShorts[i][1]));
				bListUShorts.Add (dataUShorts[i][3]);
			}

			Program.PrintTestLine ("Clamp UShorts", Program.CheckLists (aListUShorts, bListUShorts));

			List<int> aListInts = new List<int> (), bListInts = new List<int> ();
			for (int i = 0; i < dataInts.Length; i++) {
				aListInts.Add (MoreMath.Clamp (dataInts[i][2], dataInts[i][0], dataInts[i][1]));
				bListInts.Add (dataInts[i][3]);
			}

			Program.PrintTestLine ("Clamp Ints", Program.CheckLists (aListInts, bListInts));

			List<uint> aListUInts = new List<uint> (), bListUInts = new List<uint> ();
			for (int i = 0; i < dataUInts.Length; i++) {
				aListUInts.Add (MoreMath.Clamp (dataUInts[i][2], dataUInts[i][0], dataUInts[i][1]));
				bListUInts.Add (dataUInts[i][3]);
			}

			Program.PrintTestLine ("Clamp UInts", Program.CheckLists (aListUInts, bListUInts));

			List<long> aListLongs = new List<long> (), bListLongs = new List<long> ();
			for (int i = 0; i < dataLongs.Length; i++) {
				aListLongs.Add (MoreMath.Clamp (dataLongs[i][2], dataLongs[i][0], dataLongs[i][1]));
				bListLongs.Add (dataLongs[i][3]);
			}

			Program.PrintTestLine ("Clamp Longs", Program.CheckLists (aListLongs, bListLongs));

			List<ulong> aListULongs = new List<ulong> (), bListULongs = new List<ulong> ();
			for (int i = 0; i < dataULongs.Length; i++) {
				aListULongs.Add (MoreMath.Clamp (dataULongs[i][2], dataULongs[i][0], dataULongs[i][1]));
				bListULongs.Add (dataULongs[i][3]);
			}

			Program.PrintTestLine ("Clamp ULongs", Program.CheckLists (aListULongs, bListULongs));

			List<float> aListFloats = new List<float> (), bListFloats = new List<float> ();
			for (int i = 0; i < dataSingels.Length; i++) {
				aListFloats.Add (MoreMath.Clamp (dataSingels[i][2], dataSingels[i][0], dataSingels[i][1]));
				bListFloats.Add (dataSingels[i][3]);
			}

			Program.PrintTestLine ("Clamp Floats", Program.CheckLists (aListFloats, bListFloats));

			List<double> aListDoubles = new List<double> (), bListDoubles = new List<double> ();
			for (int i = 0; i < dataDoubles.Length; i++) {
				aListDoubles.Add (MoreMath.Clamp (dataDoubles[i][2], dataDoubles[i][0], dataDoubles[i][1]));
				bListDoubles.Add (dataDoubles[i][3]);
			}

			Program.PrintTestLine ("Clamp Doubles", Program.CheckLists (aListDoubles, bListDoubles));

			List<decimal> aListDecimals = new List<decimal> (), bListDecimals = new List<decimal> ();
			for (int i = 0; i < dataDecimals.Length; i++) {
				aListDecimals.Add (MoreMath.Clamp (dataDecimals[i][2], dataDecimals[i][0], dataDecimals[i][1]));
				bListDecimals.Add (dataDecimals[i][3]);
			}

			Program.PrintTestLine ("Clamp Decimals", Program.CheckLists (aListDecimals, bListDecimals));
		}

	}
}