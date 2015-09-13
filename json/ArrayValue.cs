using System.Collections.Generic;

namespace json
{
	class ArrayValue : Value
	{
		private List<Value> values = new List<Value>();
		public override void append(Value v)
		{
			values.Add(v);
		}
		public override string ToString()
		{
			string ret = "[";
			foreach (var e in values)
				ret += e.ToString() + ", ";
			if (values.Count != 0)
				ret = ret.Substring(0, ret.Length - 2);
			return ret + "]";
		}
		public override Value this[int index]
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

		public override int count()
		{
			return values.Count;
		}

	}
}