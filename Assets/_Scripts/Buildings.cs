using UnityEngine;
using System.Collections;

public class Buildings : MonoBehaviour
{

	public string answer;

	private Button restore;
	private Textbox equation_1;

	void Awake()
	{
		restore = transform.FindChild("restore").GetComponent<Button>();
		equation_1 = transform.FindChild("equation_1").GetComponent<Textbox>();
		restore.gameObject.SetActive(false);
	}

	void Update()
	{
		if (equation_1.entered == answer)
			restore.gameObject.SetActive(true);
		else
			restore.gameObject.SetActive(false);

		if (restore.clicked)
		{
			Desktop.buildings_complete = true;
			WorldController.UnlockElement("Buildings");
			PuzzleController.LoadPuzzle("Desktop");
		}
	}
}
