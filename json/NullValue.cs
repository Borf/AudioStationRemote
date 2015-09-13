using json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json
{
	class NullValue : Value
	{
		public override string ToString()
		{
			return "null";
		}
	}
}
