using UnityEngine;
using System.Collections;

public class Safemode : MonoBehaviour {

	private Button regular;
	private Button safe;

	void Start () 
	{
		regular = transform.FindChild("Regular").GetComponent<Button>();
		safe = transform.FindChild("Safe").GetComponent<Button>();
	}

	void Update () 
	{
		if (regular.clicked)
			PuzzleController.LoadPuzzle("Error");
		else if (safe.clicked)
			PuzzleController.LoadPuzzle("Desktop");
	}
}
