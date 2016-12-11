using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {

	public string password_text = "1234";

	private Textbox password;
	private Button start;

	void Start () 
	{
		password = transform.FindChild("password").GetComponent<Textbox>();
		start = transform.FindChild("start").GetComponent<Button>();
		start.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (password.entered == password_text)
			start.gameObject.SetActive(true);

		if (start.clicked)
			PuzzleController.LoadPuzzle("Safemode");
	}
}
