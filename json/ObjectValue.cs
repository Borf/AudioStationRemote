using System;
using System.Collections.Generic;

namespace json
{
	public class ObjectValue : Value
	{
		public Dictionary<string, Value> values = new Dictionary<string, Value>();

		void set(String key, Value value)
		{
			this.values[key] = value;
		}
		public override string ToString()
		{
			string ret = "{";
			foreach(var e in values)
				ret += "\"" + e.Key + "\": " + e.Value.ToString() + ", ";
			if (values.Count != 0)
				ret = ret.Substring(0, ret.Length - 2);
			return ret + "}";
		}

		public override Value this[string index]
		{
			set
			{
				values[index] = value;
			}
			get
			{
				return values[index];
			}
		}

		public override bool contains(string key)
		{
			return values.ContainsKey(key);
		}

		public override IEnumerator<KeyValuePair<string, Value>> GetEnumerator()
		{
			return values.GetEnumerator();
		}
	}
}