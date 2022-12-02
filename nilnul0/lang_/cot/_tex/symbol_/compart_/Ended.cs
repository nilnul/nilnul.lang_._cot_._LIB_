using nilnul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot._tex.symbol_.compart_
{




	public class Ended : CompartA
	{

		public Ended(Content content) : base(content)
		{
		}

		

		static public Ended Create(List<ISymbol> symbols) {
			nilnul.obj.vow_.True.Singleton.vow( symbols.First() is symbol_.LeftParen);

			return new Ended(
				new Content( 
				symbols.Skip(1).Cast<Txt0compartI>()
			)
			);

		}

		static public Ended Create(IEnumerable<ISymbol> symbols) {
			nilnul.obj.vow_.True.Singleton.vow( symbols.First() is symbol_.LeftParen);

			return new Ended(
				new Content( 
				symbols.Skip(1).Cast<Txt0compartI>()
			)
			);

		}



		public override string ToString()
		{
			return $"({boxed}";
		}



	}







}
