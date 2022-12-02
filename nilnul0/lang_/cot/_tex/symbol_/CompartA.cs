using nilnul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot._tex.symbol_
{

	public abstract class CompartA : nilnul.obj.Box<Content>, CompartI
	{
		public CompartA(Content content) : base(content)
		{

		}

		/// <summary>
		/// we can use, for example, "(Git)" or the ending "(git", to denote this is intended as git module.
		/// </summary>
		/// <returns></returns>
		public bool hasNotationCaseInsensitive(string notation)
		{
			if (boxed.txt0nul is null)
			{
				if (
					boxed.commentTxtS.Any(
						ct =>
						ct.comment.hasNotationCaseInsensitive(notation)
					)
				)
				{
					return true;
				}
				var nonBlankEs = boxed.commentTxtS.Where(
					ct => !(string.IsNullOrWhiteSpace(ct.txt0nul.ToString()))
				);
				if (nonBlankEs.Count() == 1)
				{
					if (
						nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
							nonBlankEs.First().txt0nul.ToString()
							,
							notation
						)
					)
					{
						return true;
					}
					return false;
				}
				return false;

			}

			if (boxed.Where(x => x is CompartI).Cast<CompartI>().Any(c => c.hasNotationCaseInsensitive(notation)))
			{
				return true;
			}
			var txts = boxed.Where(x => x is Txt).Cast<Txt>().Where(
				t => !(string.IsNullOrWhiteSpace(t.ToString()))
			);
			if (txts.Count() == 1)
			{
				if (
						nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
							txts.First().ToString()
							,
							notation
						)
					)
				{
					return true;
				}
				return false;
			}
			return false;



		}

		public bool hasNotationCaseInsensitiveNonrecur(
			string
			notation
		)
		{
			return boxed.txtHasNotationCaseInsensitive(notation);
	



		}
	}



}
