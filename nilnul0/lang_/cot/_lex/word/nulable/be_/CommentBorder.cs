using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot._lex.word.nulable.be_
{
	/// <summary>
	/// null or rightParen
	/// </summary>
	static public class _CommentBorderX
	{
		static public bool Be(WordI word) {
			return word is null || word is word_.RightParen || word is word_.LeftParen;
		}
	}
}
