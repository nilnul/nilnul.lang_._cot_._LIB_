using nilnul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot._tex.symbol_.compart_
{




	public class Begun : CompartA
	{
		public Begun(Content content) : base(content)
		{
		}

		static public Begun Create(IEnumerable<ISymbol> symbols)
		{
			nilnul.obj.vow_.True.Singleton.vow(symbols.Last() is symbol_.RightParen);

			return new Begun(
				new Content(
				symbols.Take(symbols.Count()-1).Cast<Txt0compartI>()
			)
			);

		}

		public override string ToString()
		{
			return $"{boxed})";
		}



	}







}
