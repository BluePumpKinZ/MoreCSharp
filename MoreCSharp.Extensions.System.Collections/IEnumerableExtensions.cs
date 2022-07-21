using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoreCSharp.Extensions.System.Collections {

	public static class IEnumerableExtensions {

		public static void ForEach (this IEnumerable iEnumerable, Action<object> action) {
			foreach (object t in iEnumerable) {
				action.Invoke (t);
			}
		}

		public static async Task ForEachAsync (this IEnumerable iEnumerable, Func<object, Task> action) {
			foreach (object t in iEnumerable) {
				await action.Invoke (t);
			}
		}

	}
}
