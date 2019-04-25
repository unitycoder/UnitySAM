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

		s = "the imperial arcturan armada is ready for battle.";

		s = "the imperial ark tooran arr mah dah is ready for battle.";

		string output = null;

		bool phonetic = false;
		if (phonetic)
		{
			s = s + "\0x9b";
		}
		else
		{
			s = s + "[";
			output = UnitySAM.TextToPhonemes(s);
		}

		Out(s);

		Out(output);
	}
}
