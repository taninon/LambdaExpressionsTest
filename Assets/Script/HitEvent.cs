using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEvent : MonoBehaviour
{
	[SerializeField] HitController hitController;

	void Start()
	{
		hitController.hitEvent += ChengeColor;
	}
	private void ChengeColor()
	{
		this.gameObject.GetComponent<Renderer>().material.color = Color.blue; ;
	}
	private void OnCollisionEnter(Collision collision)
	{
		hitController.hitEvent();
	}
}
