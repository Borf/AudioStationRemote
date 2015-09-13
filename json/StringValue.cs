using System;
using json;

namespace json
{
	public class StringValue : Value
	{
		public String value;

		public StringValue(string value)
		{
			this.value = value;
		}
		public override string asString() { return value; }
		public override string ToString()
		{
			return "\"" + value + "\"";
		}
	}
}