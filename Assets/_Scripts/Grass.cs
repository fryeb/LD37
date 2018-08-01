using UnityEngine;
using System.Collections;

public class Grass : MonoBehaviour {

	public float stopMinimum;
	public float stopMaximum;

	private Button start;
	private Button stop;
	private Button restore;

	private Mover mover;

	void Start () 
	{
		mover = transform.Find("mover").GetComponent<Mover>();

		start = transform.Find("start").GetComponent<Button>();
		stop = transform.Find("stop").GetComponent<Button>();
		restore = transform.Find("restore").GetComponent<Button>();

		start.gameObject.SetActive(false);
		restore.gameObject.SetActive(false);
		stop.gameObject.SetActive(true);
	}

	void Update () 
	{
		if (stop.clicked)
		{
			if (mover.fill < stopMaximum && mover.fill > stopMinimum) // Mover is in Range
				restore.gameObject.SetActive(true);
			else
				start.gameObject.SetActive(true);

			stop.gameObject.SetActive(false);
			mover.moving = false;
		}
		if (start.clicked)
		{
			stop.gameObject.SetActive(true);
			start.gameObject.SetActive(false);
			mover.moving = true;
		}
		if (restore.clicked)
		{
			WorldController.UnlockElement("Grass");
			Desktop.grass_complete = true;
			PuzzleController.LoadPuzzle("Desktop");
		}
	}
}
