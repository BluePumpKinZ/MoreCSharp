using System.Collections.Generic;

namespace MoreCSharp.Collections.Generic {

	public interface ILongList<T> : ILongCollection<T> {

		public long IndexOf (T item);

		public void Insert (long arrayIndex, T item);

		public void RemoveAt (long arrayIndex);

		public T this[long index] { get; set; }

	}

}