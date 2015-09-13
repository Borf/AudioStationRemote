namespace json
{
	class IntValue : Value
	{
		public int value;
		public IntValue(int value)
		{
			this.value = value;
		}
		public override int asInt() { return value; }
		public override string ToString()
		{
			return "" + value;
		}
	}
}