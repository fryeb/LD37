using UnityEngine;
using System.Collections;

public class Buildings : MonoBehaviour {

	public string answer;

	private Button restore;
	private Textbox textbox;

	void Awake()
	{
		restore = transform.FindChild("restore").GetComponent<Button>();
		textbox = transform.FindChild("x_1").GetComponent<Textbox>();
		restore.gameObject.SetActive(false);
	}

	void Update () 
	{
		if (textbox.entered == answer)
		{
			restore.gameObject.SetActive(true);
		}

		if (restore.clicked)
		{
			WorldController.UnlockElement("Buildings");
			Desktop.buildings_complete = true;
			PuzzleController.LoadPuzzle("Desktop");
		}
	}
}
