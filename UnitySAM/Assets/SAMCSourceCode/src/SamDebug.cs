using UnityEngine;

public static partial class UnitySAM
{
	static void printf(string s)
	{
		Debug.Log("Print:'" + s + "'");
	}

	static void printf(int[] ia)
	{
		byte[] bytes = new byte[ia.Length];
		for (int i = 0; i < ia.Length; i++)
		{
			if (ia[i] == 0)
			{
				var copy = new byte[i];
				System.Array.Copy( bytes, copy, i);
				bytes = copy;
				break;
			}
			bytes[i] = (byte)ia[i];
		}

		string s = System.Text.Encoding.UTF8.GetString(bytes);

		printf( s);
	}

	static void PrintRule(int i)
	{
		Debug.Log("PrintRule:" + i.ToString());
	}

	static void PrintPhonemes( int[] phonemeindex, int[] phonemeLength, int[] stress)
	{
	}
}
