namespace nilnul.lang_.cot._tex.symbol_
{
	/// <summary>
	/// content with fencing (full or half)
	/// </summary>
	public interface CompartI : ISymbol, Txt0compartI
	{
		bool hasNotationCaseInsensitive(string notation);
		bool hasNotationCaseInsensitiveNonrecur(string
			notation);
	}



}
