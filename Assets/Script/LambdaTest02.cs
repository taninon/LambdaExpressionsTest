using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaTest02 : MonoBehaviour
{
	private System.Action eventAction;

	private void Start()
	{
		eventAction = () =>
		{
			Debug.Log("匿名関数が実行されたよ");
		};
		eventAction();
	}

}
