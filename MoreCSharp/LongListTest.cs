using MoreCSharp.Collections.Generic;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MoreCSharp.Tests {

	public class LongListTest {

		public void Test () {

			// Longlist tests are performed with a reduced inner list size. (LongList<T>.BitsPerList)
			Random random = new Random ();
			LongList<int> longList = new LongList<int> ();
			List<int> list = new List<int> ();
			const int testSize = 10000;
			for (int i = 0; i < testSize; i++) {
				int value = random.Next (100);
				longList.Add (value);
				list.Add (value);
			}

			Program.PrintTestLine ("Adding", CheckLists (longList, list));

			for (int i = 0; i < testSize; i++) {
				int value = random.Next (100);
				longList.Insert (testSize - i - 1, value);
				list.Insert (testSize - i - 1, value);
			}

			Program.PrintTestLine ("Inserting", CheckLists (longList, list));

			for (int i = 0; i < testSize; i++) {
				longList.RemoveAt (i);
				list.RemoveAt (i);
			}

			Program.PrintTestLine ("Removing", CheckLists (longList, list));

			List<int> indeces1 = new List<int> (), indeces2 = new List<int> ();
			for (int i = 0; i < testSize; i++) {
				int value = random.Next (100);
				indeces1.Add ((int)longList.IndexOf (value));
				indeces2.Add (list.IndexOf (value));
			}

			Program.PrintTestLine ("Indexing", CheckLists (indeces1, indeces2));

		}

		private bool CheckLists<T> (IEnumerable<T> a, IEnumerable<T> b) {
			if (a.LongCount () != b.LongCount ())
				return false;
			foreach (Tuple<T, T> tuple in a.Zip (b, (first, second) => new Tuple<T, T> (first, second))) {
				if (!Equals (tuple.Item1, tuple.Item2))
					return false;
			}

			return true;
		}

	}

}
