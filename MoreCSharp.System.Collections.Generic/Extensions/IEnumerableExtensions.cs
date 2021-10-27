using System;
using System.Collections.Generic;

namespace MoreCSharp.System.Collections.Generic.Extensions {

	public static class IEnumerableExtensions {

		public static void ForEach<T> (this IEnumerable<T> iEnumerable, Action<T> action) {
			foreach (T t in iEnumerable) {
				action.Invoke (t);
			}
		}

	}
}
