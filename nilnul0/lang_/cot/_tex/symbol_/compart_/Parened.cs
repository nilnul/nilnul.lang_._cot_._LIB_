using nilnul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot._tex.symbol_.compart_
{




	public class Parened : CompartA
	{

		public Parened(Content content) : base(content)
		{
		}

		static public Parened Create(IEnumerable<ISymbol> symbols)
		{
			nilnul.obj.vow_.True.Singleton.vow(symbols.First() is symbol_.LeftParen);
			nilnul.obj.vow_.True.Singleton.vow(symbols.Last() is symbol_.RightParen);


			return new Parened(
				new Content(
				symbols.Skip(1).Take(symbols.Count()-2).Cast<Txt0compartI>()
			)
			);

		}

		public override string ToString()
		{
			return $"({boxed})";
		}



	}







}
