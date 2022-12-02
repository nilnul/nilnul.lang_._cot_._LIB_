using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot._tex.symbol_._content_
{
	/// <summary>
	/// comment, followed by txtNuable
	/// </summary>
	public class CompartTxt
	{
		//required
		public CompartI comment;

		/// <summary>
		/// nulable
		/// </summary>
		public Txt txt0nul; //nullable

		public CompartTxt(CompartI comment, Txt txt)
		{
			this.comment = comment;
			this.txt0nul = txt;
		}

		public CompartTxt(CompartI comment):this(comment,null)
		{

		}

		public override string ToString()
		{
			return $"{comment}{txt0nul}";
		}
	}
}
