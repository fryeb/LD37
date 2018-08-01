using UnityEngine;
using System.Collections;

public class Logo : MonoBehaviour {

	private Button power;

	void Start () 
	{
		power = transform.Find("power").GetComponent<Button>();
	}

	void Update () 
	{
		if (power.clicked)
			PuzzleController.LoadPuzzle("Off");
	}
}
