using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot._lex.word_
{
	public class Represent : RepresentI
	{


		public StringBuilder builder = new StringBuilder();


	


		public void append(char x)
		{
			builder.Append(x);
		}

		public void _append(char? _notNull)
		{
			append(_notNull.Value);
		}

		public override string ToString()
		{
			return builder.ToString();
		}

	}











}
