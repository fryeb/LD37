using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {

	public string password_text = "1234";
	private Textbox password;

	void Start () 
	{
		password = transform.FindChild("password").GetComponent<Textbox>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (password.entered == password_text)
			PuzzleController.LoadPuzzle("Safemode");
	}
}
