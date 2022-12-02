using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot._tex.symbol_
{

	/// <summary>
	/// without the contextual enclosing parens, txt is not in comment. If within parens, this txt is part of the comment.
	/// this can be nulable.
	/// eg:
	///		"abc" in abc(def
	///		"abc" in (abc(def)), when we unwrap and parse the content "abc(def"
	/// </summary>
	public class Txt :nilnul.obj.Box1<string>, Txt0compartI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="content0nul">nulable</param>
		public Txt(string content0nul):base(content0nul)
		{

		}

		public Txt(_lex.word_.Represent txt):this(txt.ToString())
		{
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		///
		[return: ReturnNull]
		public override string ToString()
		{
			return boxed;
		}

	}



}
