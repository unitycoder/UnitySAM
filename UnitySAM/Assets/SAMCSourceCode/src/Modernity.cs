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
		TextToPhonemes(IntArray( s));

		var bytes = new byte[ inputtemp.Length];
		for (int i = 0; i < 256; i++)
		{
			if (inputtemp[i] != 0)
			{
				bytes[i] = (byte)inputtemp[i];
			}
		}

		string result = System.Text.Encoding.UTF8.GetString(bytes);

		return result;
	}
}
