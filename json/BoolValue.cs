namespace json
{
	class BoolValue : Value
	{
		public bool value;
		public BoolValue(bool value)
		{
			this.value = value;
		}
		public override bool asBool() { return value; }
		public override string ToString()
		{
			return value ? "true" : "false";
		}
	}
}