using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
	public Action hitEvent;

	void Start()
	{
		hitEvent += Hit;
	}

	private void Hit()
	{
		Debug.Log("何かしら当たった");
	}

}
