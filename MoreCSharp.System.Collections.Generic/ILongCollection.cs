using System.Collections.Generic;

namespace MoreCSharp.System.Collections.Generic {

	public interface ILongCollection<T> : ICollection<T> {

		public long LongCount { get; }

	}

}