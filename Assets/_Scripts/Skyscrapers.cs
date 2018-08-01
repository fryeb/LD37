using UnityEngine;
using System.Collections;

public class Skyscrapers : MonoBehaviour {

	public float stopMinimum;
	public float stopMaximum;

	private Button start;
	private Button stop;
	private Button restore;

	private Mover mover_1;
	private Mover mover_2;
	private Mover mover_3;

	void Awake () 
	{
		start = transform.Find("start").GetComponent<Button>();
		stop = transform.Find("stop").GetComponent<Button>();
		restore = transform.Find("restore").GetComponent<Button>();

		start.gameObject.SetActive(false);
		stop.gameObject.SetActive(true);
		restore.gameObject.SetActive(false);

		mover_1 = transform.Find("mover_1").GetComponent<Mover>();
		mover_2 = transform.Find("mover_2").GetComponent<Mover>();
		mover_3 = transform.Find("mover_3").GetComponent<Mover>();
	}

	void Update () 
	{
		if (stop.clicked)
		{
			mover_1.moving = false;
			mover_2.moving = false;
			mover_3.moving = false;

			bool mover_1_inrange = mover_1.fill < stopMaximum && mover_1.fill > stopMinimum;
			bool mover_2_inrange = mover_2.fill < stopMaximum && mover_2.fill > stopMinimum;
			bool mover_3_inrange = mover_3.fill < stopMaximum && mover_3.fill > stopMinimum;

			if (mover_1_inrange && mover_2_inrange && mover_3_inrange)
				restore.gameObject.SetActive(true);
			else
				start.gameObject.SetActive(true);

			stop.gameObject.SetActive(false);
		}

		if (start.clicked)
		{
			start.gameObject.SetActive(false);
			stop.gameObject.SetActive(true);

			mover_1.moving = true;
			mover_2.moving = true;
			mover_3.moving = true;
		}

		if (restore.clicked)
		{
			WorldController.UnlockElement("Skyscrapers");
			Desktop.skyscrapers_complete = true;
			PuzzleController.LoadPuzzle("Desktop");
		}
	}
}
