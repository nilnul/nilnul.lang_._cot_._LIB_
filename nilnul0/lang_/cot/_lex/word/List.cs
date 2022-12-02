using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot._lex.word
{
	public class List:List<WordI>
	{
		public override string ToString()
		{
			return string.Join("",this);
		}
	}
}
