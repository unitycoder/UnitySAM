using UnityEngine;

public static partial class UnitySAM
{
	static void Print(string s)
	{
		Debug.Log("Print:" + s);
	}

	static void PrintRule(int i)
	{
		Debug.Log("PrintRule:" + i.ToString());
	}

	static void PrintPhonemes( int[] phonemeindex, int[] phonemeLength, int[] stress)
	{
	}
}
