using System;
namespace System.Windows.Forms
{
	public static class Locale
	{
		public static string GetText(string instring)
		{
			return instring;	
		}
		public static string GetText(string inString, params object[] strings)
		{
			return String.Format(inString,strings);
		}
	}
}

