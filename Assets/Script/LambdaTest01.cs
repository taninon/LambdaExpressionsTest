using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaTest01 : MonoBehaviour
{
	private System.Action eventAction;

	private void Start()
	{
		eventAction = Test;
		eventAction();
	}

	private void Test()
	{
		Debug.Log("Testが実行されたよ");
	}
}
