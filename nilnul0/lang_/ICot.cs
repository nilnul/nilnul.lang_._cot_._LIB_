using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.lang_
{
	/// vs regex:::::::::::
	/// regex result is linearly sorted tokens; for this, the result is a tree
	/// for regex, the parser would go unbacktracked, and the result is linear.
	/// for this, the result is a tree. Note the parenthesis is paired like "(())", and the openings and the ends are of the same number; that cannot be guranteed by regex.
	///		in nilnul, we allow, but not recommend,  unpaired parens by imaging there are invisible openning at the beginning, and invisible closings at the end.
	///			eg:
	///				ad(ads
	///					is imagined as: ad(ads)
	///				a(bc)da)a
	///					is imagined as:
	///						(a(bc)da)a

	/// nilnul.lang_.bit is subtyping this;
	/// nilnul.lang_.cognom is extension of this;
	
	///
	/// <summary>
	/// commented text
	/// </summary>
	/// <remarks>
	/// eg:
	///		"", the empty str
	///		()
	///		(abc)
	///		a(b)c
	///		ab(
	///		ab(c
	///		asd)c
	///		)c
	///		a(bc).de(fa.da)e.ad(a
	///		1+2*(3+5)
	///	nilnul.lang_.bit is a subtype of this; As there is only nary/unary/binary op, we imagine inserting some invisible parenthesis.
	/// </remarks>
	/// alias:
	///		cot:
	///			commented text
	///			commented tree
	///			sounds like "quote"
	///			compart
	///				closed txt
    public interface ICot
    {
    }
}
