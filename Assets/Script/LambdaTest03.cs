using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaTest03 : MonoBehaviour
{
	private System.Action<string> eventAction;

	private void Start()
	{
		eventAction = (text) =>
		{
			Debug.Log("匿名関数が" + text);
		};
		eventAction("実行されたよ");

	}

}
