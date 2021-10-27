using System;
using System.Collections;

namespace MoreCSharp.System.Collections {

	public static class IEnumerableExtensions {

		public static void ForEach (this IEnumerable iEnumerable, Action<object> action) {
			foreach (object t in iEnumerable) {
				action.Invoke (t);
			}
		}

	}
}
