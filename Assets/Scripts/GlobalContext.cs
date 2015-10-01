using UnityEngine;
using System.Collections;
using System;

public class GlobalContext : MonoBehaviour {

	public static bool Paused = false;
	public static DateTime? TotalTimePlayed;

	void Awake() {
		if (GlobalContext.TotalTimePlayed == null) {
			GlobalContext.TotalTimePlayed = DateTime.Now;
		}
		DontDestroyOnLoad (transform.gameObject);
	}

	// Use this for initialization
	void Start () {
		((DateTime)GlobalContext.TotalTimePlayed).AddDays (1);
		print (((DateTime)GlobalContext.TotalTimePlayed).ToShortDateString());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
