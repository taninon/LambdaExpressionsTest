using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaTest0103 : MonoBehaviour
{
	private System.Action<string> eventAction;
	void Start()
	{
		eventAction = Test;
		eventAction("引数");
	}

	private void Test(string argText)
	{
		Debug.Log(argText + "付きでTestが実行されたよ");
	}
}
