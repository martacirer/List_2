using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ex_2 : MonoBehaviour
{
   Image Timer;
   public float MaxTime = 30f;
   float TimeLeft;

   public GameObject timeBar;

	void Start()
		{
			
			Timer = GetComponent<Image> ();
			TimeLeft = MaxTime;
		}

	void Update()
	{
		if(TimeLeft > 0)
		{
			TimeLeft -= Time.deltaTime;
			Timer.fillAmount = TimeLeft / MaxTime;
		}else
		{
			timeBar.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
