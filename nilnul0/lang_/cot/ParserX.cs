using nilnul.lang_.cot._tex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot
{
	/// <summary>
	/// change words to symbols
	/// </summary>
	/// todo:
	static public class TexX
	{




		static public _tex.symbol_.compart_.Ended _Reduce2CommentEnded(List<ISymbol> symbols)
		{
			return _tex.symbol_.compart_.Ended.Create(symbols);
		}

		static public _tex.symbol_.compart_.Ended _Reduce2CommentEnded(IEnumerable<ISymbol> symbols)
		{
			return _tex.symbol_.compart_.Ended.Create(symbols);
		}


		static public _tex.symbol_.Content _Reduce2content(IEnumerable<ISymbol> symbols)
		{
			return new _tex.symbol_.Content(symbols.Cast<_tex.symbol_.Txt0compartI>());
		}



		static public _tex.symbol_.compart_.Parened _Reduce2CommentParened(IEnumerable<ISymbol> symbols)
		{
			return _tex.symbol_.compart_.Parened.Create(symbols);
		}



		static public _tex.symbol_.compart_.Begun _Reduce2CommentBegun(IEnumerable<ISymbol> symbols)
		{
			return _tex.symbol_.compart_.Begun.Create(symbols);
		}




		static public _tex.symbol_.Content Parse(_lex.word.Slider words)
		{

			nilnul.obj.slider_.Stuck<ISymbol> stuck = new obj.slider_.Stuck<ISymbol>();

			while (true)
			{
				switch (words.current)
				{
					case null:

						var popped12 = stuck.popWhile(
							x => !(x is _tex.symbol_.LeftParen) && !(x is null)
						);



						switch (stuck.current)
						{
							case null:
								popped12.Reverse();

								stuck.push(_Reduce2content(popped12));
								if (stuck.current == null)
								{
									return new _tex.symbol_.Content();
								}

								return (_tex.symbol_.Content)stuck.current;
								break;
							default:
								popped12.Add(stuck.pop());
								popped12.Reverse();
								stuck.push(_Reduce2CommentEnded(popped12));

								break;
						}

						break;
					case _lex.word_.RightParen rightParen:
						stuck.push(new _tex.symbol_.RightParen());

						var popped4RightParen = stuck.pop(1).Concat(
							stuck.popWhile(
								x =>
									!(x is _tex.symbol_.LeftParen)
									&&
									!(x == null)
							)
						).ToList();

						switch (stuck.current)
						{
							case null:
								popped4RightParen.Reverse();
								var reduced = _Reduce2CommentBegun(popped4RightParen);

								stuck.push(
									reduced
								);

								break;

							default:

								popped4RightParen.Add(stuck.pop());
								popped4RightParen.Reverse();
								stuck.push(_Reduce2CommentParened(popped4RightParen));
								break;
						}

						;
						break;
					case _lex.word_.Represent txt:
						stuck.push(new _tex.symbol_.Txt(txt));

						break;

					case _lex.word_.LeftParen leftParen:
						stuck.push(new _tex.symbol_.LeftParen());

						break;
					default:


						throw new UnexpectedTypeException();
						break;
				}
				words.moveNext();

			}


		}

		static public _tex.symbol_.Content Parse(Lex lexResult)
		{
			return Parse(
				new _lex.word.Slider(lexResult)
			);

		}

		/// <summary>
		/// 
		/// </summary>
		static public _tex.symbol_.Content Parse(string s)
		{
			return Parse(new Lex(s));




		}




	}
}

