using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaTest04 : MonoBehaviour
{
	private List<string> testList = new List<string>() { "埼玉", "東京", "神奈川" };

	private void Start()
	{
		var saitama = testList.Exists((search) => search == "埼玉");
		Debug.Log("Listの中に埼玉は:" + saitama);

		var chiba = testList.Exists((search) => search == "千葉");
		Debug.Log("Listの中に千葉は:" + chiba);
	}

}

