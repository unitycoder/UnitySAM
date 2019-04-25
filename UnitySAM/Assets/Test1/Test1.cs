using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
	void Start ()
    {
        string s = "HELLO";

        var x = UnitySAM.TextToPhonemes(s);

        Debug.Log(x.ToString());
	}
}
