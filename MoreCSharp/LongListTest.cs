using System.Collections.Generic;
using System;
using MoreCSharp.System.Collections.Generic;

namespace MoreCSharp.Tests {

	public class LongListTest {

		public void Test () {

			// Longlist tests are performed with a reduced inner list size. (LongList<T>.BitsPerList)
			Random random = new Random ();
			LongList<int> longList = new LongList<int> ();
			List<int> list = new List<int> ();
			const int testSize = 1000;
			for (int i = 0; i < testSize; i++) {
				int value = random.Next (100);
				longList.Add (value);
				list.Add (value);
			}

			Program.PrintTestLine ("Adding", Program.CheckLists (longList, list));

			for (int i = 0; i < testSize; i++) {
				int value = random.Next (100);
				longList.Insert (testSize - i - 1, value);
				list.Insert (testSize - i - 1, value);
			}

			Program.PrintTestLine ("Inserting", Program.CheckLists (longList, list));

			for (int i = 0; i < testSize; i++) {
				longList.RemoveAt (i);
				list.RemoveAt (i);
			}

			Program.PrintTestLine ("Removing", Program.CheckLists (longList, list));

			List<int> indeces1 = new List<int> (), indeces2 = new List<int> ();
			for (int i = 0; i < testSize; i++) {
				int value = random.Next (100);
				indeces1.Add ((int)longList.IndexOf (value));
				indeces2.Add (list.IndexOf (value));
			}

			Program.PrintTestLine ("Indexing", Program.CheckLists (indeces1, indeces2));

		}

	}

}
