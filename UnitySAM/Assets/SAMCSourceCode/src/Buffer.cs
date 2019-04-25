using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffer
{
	List<int> Data;

	public Buffer()
	{
		Data = new List<int>();
	}

	public int[] Get()
	{
		return Data.ToArray();
	}

	public int GetSize()
	{
		return Data.Count;
	}

	public void Set( int position, int data)
	{
		while( position >= Data.Count)
		{
			Data.Add( 0);
		}
		Data[position] = data;
	}
}
