using System;
using System.Collections;
using System.Collections.Generic;

namespace MoreCSharp.Collections.Generic {
	public class LongList<T> : ILongList<T> {

		private const int BitsPerList = 6;
		private const int MaxItemsPerList = 1 << BitsPerList;
		private const long LowerBitMask = MaxItemsPerList - 1;
		private const long HigherBitMask = ~LowerBitMask & ~(1L << 63);

		private readonly List<List<T>> _items;
		private long _count;

		public LongList () {
			_items = new List<List<T>> ();
		}

		public LongList (long capacity) {
			if (capacity < 0)
				throw new ArgumentException ("Capacity must be zero or greater.", nameof (capacity));
			_items = new List<List<T>> ();
			while (capacity > 0) {
				long subtractAmount = capacity;
				if (subtractAmount > MaxItemsPerList)
					subtractAmount = MaxItemsPerList;
				_items.Add (new List<T> ((int)subtractAmount));
				capacity -= subtractAmount;
			}
		}

		public IEnumerator<T> GetEnumerator () {
			return new LongListEnum (this);
		}

		IEnumerator IEnumerable.GetEnumerator () {
			return GetEnumerator ();
		}

		private void ShiftListsRight (long freeIndex) {
			AddFirst (this[_count - 1]);
			for (long i = _count - 2; i >= freeIndex; i--) {
				this[i + 1] = this[i];
			}
		}

		private void ShiftListsLeft (long removeIndex) {
			for (long i = removeIndex; i < _count - 1; i++) {
				this[i] = this[i + 1];
			}
			RemoveFirst ();
		}

		private void AddFirst (T item) {
			GetListIndeces (out int listIndex, out _);
			if (_items.Count <= listIndex)
				_items.Add (new List<T> ());
			_items[listIndex].Add (item);
			_count++;
		}

		private T RemoveFirst () {
			if (_count == 0)
				throw new IndexOutOfRangeException ("List already empty, cannot remove further");
			T toReturn = _items[^1][^1];
			_items[^1].RemoveAt (_items[^1].Count - 1);
			if (_items[^1].Count == 0)
				_items.RemoveAt (_items.Count - 1);
			_count--;
			return toReturn;
		}

		public void Add (T item) {
			AddFirst (item);
		}

		public void Clear () {
			for (int i = 0; i < _items.Count; i++)
				_items[i].Clear ();
			_items.Clear ();
			_count = 0;
		}

		public bool Contains (T item) {
			foreach (T t in this) {
				if (Equals (t, item))
					return true;
			}
			return false;
		}

		public void CopyTo (T[] array, int arrayIndex) {
			if (arrayIndex + _count >= array.Length)
				throw new ArgumentException ("Array is not big enough.", nameof (arrayIndex));
			foreach (T t in this) {
				array[arrayIndex++] = t;
			}
		}

		public bool Remove (T item) {
			long index = IndexOf (item);

			if (index == -1)
				return false;
			RemoveAt (index);
			return true;
		}

		public long Capacity {
			get {
				int count = _items.Count;
				if (count == 0)
					return 0;

				return (count - 1L) * MaxItemsPerList + _items[^1].Capacity;
			}
		}

		public int Count {
			get {
#warning Use of Count is capped at int.MaxValue
				return LongCount >= int.MaxValue ? int.MaxValue : (int)LongCount;
			}
		}

		public bool IsReadOnly { get { return false; } }

		public long LongCount => _count;

		public void ForEach (Action<T> action) {
			foreach (T t in this) {
				action.Invoke (t);
			}
		}

		public long IndexOf (T item) {
			long index = 0;
			for (int i = 0; i < _items.Count; i++) {
				for (int j = 0; j < _items[i].Count; j++) {
					if (Equals (_items[i][j], item))
						return index;
					index++;
				}
			}

			return -1;
		}

		public void Insert (long arrayIndex, T item) {
			ShiftListsRight(arrayIndex);
			this[arrayIndex] = item;
		}

		public void RemoveAt (long arrayIndex) {
			ShiftListsLeft (arrayIndex);
		}

		private static void GetListIndeces (long index, out int listIndex, out int innerListIndex) {
			innerListIndex = (int)(index & LowerBitMask);
			listIndex = (int)((index & HigherBitMask) >> BitsPerList);
		}

		private void GetListIndeces (out int listIndex, out int innerListIndex) {
			GetListIndeces (_count, out listIndex, out innerListIndex);
		}

		public T this[long index] {
			get {
				GetListIndeces (index, out int listIndex, out int innerListIndex);
				return _items[listIndex][innerListIndex];
			}
			set {
				GetListIndeces (index, out int listIndex, out int innerListIndex);
				_items[listIndex][innerListIndex] = value;
			}
		}

		private class LongListEnum : IEnumerator<T> {

			private T _current;
			private LongList<T> _list;
			private IEnumerator<List<T>> _outerListEnum;
			private IEnumerator<T> _innerListEnum;

			public object Current => _current;

			public LongListEnum (LongList<T> list) {
				_list = list;
				Reset ();
			}

			public bool MoveNext () {
			TryAgain:
				if (_innerListEnum.MoveNext ()) {
					_current = _innerListEnum.Current;
					return true;
				}

				if (!_outerListEnum.MoveNext ())
					return false;
				_innerListEnum = _outerListEnum.Current.GetEnumerator ();

				goto TryAgain;
			}

			public void Reset () {
				_outerListEnum = _list._items.GetEnumerator ();
				if (_list._items.Count != 0)
					_innerListEnum = new List<T> ().GetEnumerator ();
			}

			T IEnumerator<T>.Current => _current;

			public void Dispose () {
				_outerListEnum.Dispose ();
				_innerListEnum.Dispose ();
				_list = null;
			}

		}

	}
}