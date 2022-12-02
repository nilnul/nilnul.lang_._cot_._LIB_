using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.cot._tex.symbol_._content_
{
	public class CompartTxtEs : List<CompartTxt>
	{

		public void append(
			symbol_.CompartI leading,
			nilnul.obj.slider.construct_.seq_._appendNul.Ret<Txt0compartI> enumerator
		)
		{
			switch (enumerator.current)
			{
				case symbol_.CompartI comment:
					this.Add(new CompartTxt(leading));
					enumerator.moveNext();
					append(comment, enumerator);
					break;
				case symbol_.Txt currentTxt:
					this.Add(new CompartTxt(leading, currentTxt));
					enumerator.moveNext();
					append(enumerator);
					break;
				case null:
					this.Add(new CompartTxt(leading));

					break;
				default:
					throw new UnexpectedTypeException();
					break;
			}
		}

		/// <summary>
		/// must be comment -leaded
		/// </summary>
		/// <param name="enumerator"></param>
		public void append(nilnul.obj.slider.construct_.seq_._appendNul.Ret<Txt0compartI> enumerator)
		{

			switch (enumerator.Current)
			{
				case symbol_.CompartI comment:
					enumerator.moveNext();
					append(comment, enumerator);
					break;
				case null:

					break;

				default:
					throw new UnexpectedTypeException();
					break;
			}


		}


		public void append(IEnumerable<Txt0compartI> enumerable)
		{
			append(
				new nilnul.obj.slider.construct_.seq_._appendNul.Ret<Txt0compartI>(
					enumerable
				)
			);
		}

		static public CompartTxtEs Create(IEnumerable<Txt0compartI> enumerable)
		{
			var r = new CompartTxtEs();
			r.append(enumerable);
			return r;
		}

		public override string ToString()
		{
			return string.Join("", this);
		}

		public IEnumerable<Txt0compartI> enumerate()
		{
			foreach (var item in this)
			{
				yield return item.comment;
				if (item.txt0nul != null)
				{
					yield return item.txt0nul;
				}
			}
		}
	}
}
