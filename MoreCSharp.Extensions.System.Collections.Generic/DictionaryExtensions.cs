using System.Collections.Generic;

namespace MoreCSharp.Extensions.System.Collections.Generic {

    public static class DictionaryExtensions {

        public static void AddOrUpdate<TKey, TValue> (this Dictionary<TKey, TValue> dictionary, TKey key, TValue value) {
            if (dictionary.TryAdd (key, value))
                return;
            dictionary[key] = value;
        }

        public static TValue GetOrAdd<TKey, TValue> (this Dictionary<TKey, TValue> dictionary, TKey key) where TValue : new () {
            if (dictionary.TryGetValue (key, out TValue value))
                return value;
            TValue newValue = new TValue ();
            dictionary.Add (key, newValue);
            return newValue;
        }

    }

}
