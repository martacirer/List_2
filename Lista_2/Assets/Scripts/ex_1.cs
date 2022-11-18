using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_1 : MonoBehaviour
{
	private ex_1_2 ex_1_2_script;
	
	// find the other script
	void Start()
	{
		ex_1_2_script = FindObjectOfType<ex_1_2>();
	}

	// destroy the sphere when you click
	public void OnMouseDown()
	{
		ex_1_2_script.Counter--;
		Destroy(gameObject);
	}
}
