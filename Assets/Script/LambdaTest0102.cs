using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaTest0102 : MonoBehaviour
{
	private System.Action eventAction;
	private void Start()
	{
		eventAction += Test1;
		eventAction += Test2;
		eventAction();
	}

	private void Test1()
	{
		Debug.Log("Test1が実行されたよ");
	}
	private void Test2()
	{
		Debug.Log("Test2が実行されたよ");
	}
}
