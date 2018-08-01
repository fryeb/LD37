using UnityEngine;
using System.Collections;

public class Safemode : MonoBehaviour {

	private Button regular;
	private Button safe;

	void Start () 
	{
		regular = transform.Find("Regular").GetComponent<Button>();
		safe = transform.Find("Safe").GetComponent<Button>();
	}

	void Update () 
	{
		if (regular.clicked)
			PuzzleController.LoadPuzzle("Error");
		else if (safe.clicked)
			PuzzleController.LoadPuzzle("Desktop");
	}
}
