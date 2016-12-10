using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Life : MonoBehaviour
{

	public int target = 99;
	private int clicked = 0;

	private Text text;
	private Button restore;
	private Button fix;

	void Start()
	{
		restore = transform.FindChild("restore").GetComponent<Button>();
		fix = transform.FindChild("fix").GetComponent<Button>();
		text = transform.FindChild("text").GetComponent<Text>();

		restore.gameObject.SetActive(false);
		fix.gameObject.SetActive(true);
	}

	void Update()
	{
		text.text = clicked.ToString();

		if (fix.clicked)
		{
			fix.clicked = false;
			clicked++;
		}

		if (clicked >= target)
		{
			fix.gameObject.SetActive(false);
			restore.gameObject.SetActive(true);
		}

		if (restore.clicked)
		{
			Desktop.roads_complete = true;
			WorldController.UnlockElement("Life");
			PuzzleController.LoadPuzzle("SuperError");
		}
	}
}