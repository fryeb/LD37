using UnityEngine;
using System.Collections;

public class Skyscrapers : MonoBehaviour {

	private Button start;
	private Button stop;
	private Button restore;

	private Mover mover_1;
	private Mover mover_2;
	private Mover mover_3;

	void Awake () 
	{
		start = transform.FindChild("start").GetComponent<Button>();
		stop = transform.FindChild("stop").GetComponent<Button>();
		restore = transform.FindChild("restore").GetComponent<Button>();

		start.gameObject.SetActive(false);
		stop.gameObject.SetActive(true);
		restore.gameObject.SetActive(false);

		mover_1 = transform.FindChild("mover_1").GetComponent<Mover>();
		mover_2 = transform.FindChild("mover_2").GetComponent<Mover>();
		mover_3 = transform.FindChild("mover_3").GetComponent<Mover>();
	}

	void Update () 
	{
	
	}
}
