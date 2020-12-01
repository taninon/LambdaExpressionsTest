using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaTest05 : MonoBehaviour
{
	private class Character
	{
		public int Id;
		public string Name;

		public Character(int id, string name)
		{
			Id = id;
			Name = name;
		}
	}

	private List<Character> characters = new List<Character>();

	private void Start()
	{
		characters.Add(new Character(1, "涼風"));
		characters.Add(new Character(2, "矢神"));
		var getChar = characters.Find((c) => c.Id == 2);
		Debug.Log("Id2のキャラ名" + getChar.Name);
	}
}
