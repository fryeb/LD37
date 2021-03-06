﻿using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {

	public string password_text = "1234";

	private Textbox password;
	private Button start;

	void Start () 
	{
		password = transform.Find("password").GetComponent<Textbox>();
		start = transform.Find("start").GetComponent<Button>();
		start.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (password.entered == password_text)
			start.gameObject.SetActive(true);
		else
			start.gameObject.SetActive(false);

		if (start.clicked)
			PuzzleController.LoadPuzzle("Safemode");
	}
}
