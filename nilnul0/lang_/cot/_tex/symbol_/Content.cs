using nilnul.lang_.cot._tex;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot._tex.symbol_
{

	/// <summary>
	/// the start symbol
	/// </summary>
	public class Content
		:
		ISymbol
		,
		IContent
		,
		IEnumerable<Txt0compartI>


	{

		/// <summary>
		/// nullable
		/// </summary>
		public Txt txt0nul;   

		private _content_.CompartTxtEs _commentTxtS;

		public _content_.CompartTxtEs commentTxtS
		{
			get { return _commentTxtS; }
			//set { _commentTxtS = value; }
		}

	
		public Content(string txt, _content_.CompartTxtEs commentTxtS)
		{
			this.txt0nul = new Txt(txt);
			this._commentTxtS = commentTxtS;
		}

		public Content(string txt) : this(txt, new _content_.CompartTxtEs())
		{

		}

		public Content() : this((string)null)
		{

		}


		public Content(IEnumerable<Txt0compartI> enumerable)
		{


			if (enumerable.Any())
			{
				if (enumerable.First() is symbol_.Txt)
				{
					txt0nul = enumerable.First() as symbol_.Txt;
					_commentTxtS = _content_.CompartTxtEs.Create(
						enumerable.Skip(1)
					);
				}
				else if (enumerable.First() is symbol_.CompartI)
				{
					_commentTxtS = _content_.CompartTxtEs.Create(
						enumerable
					);
				}
				else
				{
					throw new UnexpectedTypeException();
				}
			}
			else
			{
				_commentTxtS = new _content_.CompartTxtEs();

			}


		}

		static public Content CreateFroTxt(string txt)
		{
			return new Content(txt);
		}

		public override string ToString()
		{
			return $"{txt0nul}{commentTxtS}";
		}

		/// <summary>
		/// the outermost comment's content
		/// </summary>
		/// <param name="notation"></param>
		/// <returns></returns>
		public bool txtHasNotationCaseInsensitive(
			string notation
		)
		{
			
			var txts = this.Where(x => x is Txt).Cast<Txt>().Where(
				t => !(string.IsNullOrWhiteSpace(t.ToString()))
			).ToArray();

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


		public IEnumerator<Txt0compartI> GetEnumerator()
		{
			if (txt0nul != null)
			{
				yield return txt0nul;
			}
			foreach (var item in commentTxtS.enumerate())
			{
				yield return item;
			}

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}



}
