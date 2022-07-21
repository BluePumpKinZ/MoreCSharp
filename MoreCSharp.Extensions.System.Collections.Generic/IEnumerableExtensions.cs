using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoreCSharp.Extensions.System.Collections.Generic {

	public static class IEnumerableExtensions {

		public static void ForEach<T> (this IEnumerable<T> iEnumerable, Action<T> action) {
			foreach (T t in iEnumerable) {
				action.Invoke (t);
			}
        }

		public static async Task ForEachAsync<T> (this IEnumerable<T> iEnumerable, Func<T, Task> action) {
			foreach (T t in iEnumerable) {
				await action.Invoke(t);
			}
		}

	}
}
