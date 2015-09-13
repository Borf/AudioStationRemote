namespace json
{
	public class FloatValue : Value
	{
		public float value;
		public FloatValue(float value)
		{
			this.value = value;
		}
		public override float asFloat() { return value; }
		public override string ToString()
		{
			return "" + value;
		}
	}
}