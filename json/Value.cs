using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json
{
	public abstract class Value : IEnumerable<KeyValuePair<string, Value>>
	{
		public virtual Value this[int index]
		{
			set
			{
				throw new Exception("uhoh");
			}
			get
			{
				throw new Exception("uhoh");
			}
		}
		public virtual Value this[string index]
		{
			set
			{
				throw new Exception("uhoh");
			}
			get
			{
				throw new Exception("uhoh");
			}
		}

		public override abstract String ToString();
		public static Value fromString(String data)
		{
			return eatValue(new StringBuilder(data));
		}

		private static void ltrim(StringBuilder data)
		{
			while (data.Length > 0 && data[0] == ' ' || data[0] == '\t' || data[0] == '\r' || data[0] == '\n')
				data.Remove(0,1);
		}

		private static Value eatValue(StringBuilder data)
		{

			ltrim(data);
			if (data[0] == '[')
				return eatArray(data);
			if (data[0] == '{')
				return eatObject(data);
			if ((data[0] >= '0' && data[0] <= '9') || data[0] == '.' || data[0] == '-')
				return eatNumeric(data);
			if (data[0] == '"')
				return eatString(data);
			if (data[0] == 't' || data[0] == 'f')
				return eatBool(data);
			if (data[0] == 'n')
				return eatNull(data);
			return null;
		}


		private static Value eatBool(StringBuilder data)
		{
			bool value = data[0] == 't';
			data.Remove(0, value ? 4 : 5);
			return new BoolValue(value);
		}
		private static Value eatNull(StringBuilder data)
		{
			data.Remove(0, 4);
			return new NullValue();
		}

		private static Value eatString(StringBuilder data)
		{
			String value = "";
			data.Remove(0,1);
			bool escaped = false;
			while (data[0] != '"' || escaped)
			{
				if (data[0] == '\\' && !escaped)
					escaped = true;
				else
				{
					value += data[0];
					escaped = false;
				}
			
				data.Remove(0,1);
			}
			data.Remove(0,1);
			return new StringValue(value);
		}


		private static Value eatNumeric(StringBuilder data)
		{
			String value = "";
			while ((data[0] >= '0' && data[0] <= '9') || data[0] == '.' || data[0] == '-')
			{
				value += data[0];
				data.Remove(0,1);
			}

			if (value.IndexOf(".") != -1)
				return new FloatValue(float.Parse(value));
			else
				return new IntValue(int.Parse(value));
		}


		private static Value eatObject(StringBuilder data)
		{
			ObjectValue array = new ObjectValue();
			data.Remove(0, 1);
			bool inArray = true;
			while (inArray)
			{
				ltrim(data);
				if (data[0] != '{')
				{
					if (data[0] != '"')
						Console.WriteLine("Error getting object key, \" expected");
					data.Remove(0, 1);
					String key = "";
					while (data[0] != '"')
					{
						key += data[0];
						data.Remove(0, 1);
					}
					data.Remove(0, 1);

					ltrim(data);
					if (data[0] != ':')
						Console.WriteLine("Error getting object key, \" expected");
					data.Remove(0, 1);

					array[key] = eatValue(data);
					ltrim(data);
				}

				if (data[0] == '}')
					inArray = false;
				else if (data[0] == ',')
					inArray = true;
				else
					Console.WriteLine("Error while parsing json object");
				data.Remove(0, 1);
			}
			return array;
		}


		private static Value eatArray(StringBuilder data)
		{
			json.ArrayValue array = new json.ArrayValue();
			data.Remove(0,1);
			bool inArray = true;
			while (inArray)
			{
				if (data[0] != ']')
					array.append(eatValue(data));
				ltrim(data);
				if (data[0] == ']')
					inArray = false;
				else if (data[0] == ',')
					inArray = true;
				else
					Console.WriteLine("Error while parsing json array");

				data.Remove(0,1);
			}
			return array;
		}



		public virtual int count() { throw new Exception("nuh-uh"); }
		public virtual bool contains(string key) {  throw new Exception("nope");}
		public virtual void append(Value v) { throw new Exception("Adding something to non-array"); }

		public virtual int		asInt() { throw new Exception("No int value"); }
		public virtual float	asFloat() { throw new Exception("No float value"); }
		public virtual string	asString() { throw new Exception("No string value"); }
		public virtual bool		asBool() { throw new Exception("No bool value"); }

		public virtual IEnumerator<KeyValuePair<string, Value>> GetEnumerator()
		{
			throw new Exception("No object");	
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new Exception("No object");
		}

		public static implicit operator float(Value v)
		{
			return v.asFloat();
		}
		public static implicit operator string(Value v)
		{
			return v.asString();
		}
		public static implicit operator int(Value v)
		{
			return v.asInt();
		}
		public static implicit operator bool(Value v)
		{
			return v.asBool();
		}

		public static implicit operator Value(string v)
		{
			return new StringValue(v);
		}
		public static implicit operator Value(int v)
		{
			return new IntValue(v);
		}
		public static implicit operator Value(float v)
		{
			return new FloatValue(v);
		}
		public static implicit operator Value(bool v)
		{
			return new BoolValue(v);
		}


	}
}
