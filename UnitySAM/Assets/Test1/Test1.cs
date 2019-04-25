using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test1 : MonoBehaviour
{
	public	Text	TextOutput;

	void Out( string s)
	{
		if (s == null)
		{
			TextOutput.text = "";
			return;
		}

		var t = TextOutput.text;

		t = t + s;
		t = t + "\n";

		TextOutput.text = t;
	}

	void Start ()
    {
		Out(null);

        string s = "HELLO";

		Out(s);

        var x = UnitySAM.TextToPhonemes(s);

		Out(x);
	}
}
