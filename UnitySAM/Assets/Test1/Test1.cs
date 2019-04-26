﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test1 : MonoBehaviour
{
	public	Text	TextOutput;

	public InputField inputField;

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

	void SayString ( string s)
    {
//		s = s + ".";		// TODO: my C# port seems to crash without final punctuation.

		Out(null);

		string output = null;

		int[] ints = null;

		bool phonetic = false;
		if (phonetic)
		{
			ints = UnitySAM.IntArray( s);

			var L = new List<int>(ints);
			L.Add(155);
			ints = L.ToArray();
				
			output = s + "\0x9b";
		}
		else
		{
			output = UnitySAM.TextToPhonemes(s + "[", out ints);
		}

		Out("Input:" + s);

		Out("Phonemes:" + output);

		UnitySAM.SetInput(ints);

		var buf = UnitySAM.SAMMain();
		if (buf == null)
		{
			Debug.LogError( "Buffer was null");
		}
		else
		{
			Debug.Log( "Buffer size is " + buf.GetSize());
		}

		AudioClip ac = AudioClip.Create( "Hello", buf.GetSize(), 1, 22050, false);
		ac.SetData( buf.GetFloats(), 0);
		AudioSource.PlayClipAtPoint( ac, Camera.main.transform.position);
	}

	void SayInputField( string s)
	{
		SayString( s);
	}

	void Start()
	{
		inputField.onEndEdit.AddListener( SayInputField);

		string s = "HELLO";

		s = "the imperial arcturan armada is ready for battle.";

		s = "the imperial ark tooran arr mah dah is ready for battle.";

		//SayString( s);
	}
}
