using UnityEngine;

public static partial class UnitySAM
{
	static int[] IntArray(string s)
	{
		s = s.ToUpper();

		var bytes = System.Text.Encoding.ASCII.GetBytes(s);

		int[] intarray = new int[256];
		for (int i = 0; i < bytes.Length; i++)
		{
			intarray[i] = bytes[i];
			intarray[i + 1] = 0x80;
		}
		return intarray;
	}

	public static string TextToPhonemes(string s)
	{
		var ia = IntArray( s);

		bool success = TextToPhonemes(ia);

		Debug.Log( "success = " + success);

		var what = ia;

		what = inputtemp;

		var bytes = new byte[ what.Length];
		for (int i = 0; i < 256; i++)
		{
			if (what[i] != 0)
			{
				bytes[i] = (byte)what[i];
			}
		}

		string result = System.Text.Encoding.UTF8.GetString(bytes);

		return result;
	}
}
