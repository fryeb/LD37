using UnityEngine;
using System.Collections;

public class Off : MonoBehaviour
{

	private Button power;

	void Start()
	{
		power = transform.FindChild("power").GetComponent<Button>();
	}

	void Update()
	{
		if (power.clicked)
			PuzzleController.LoadPuzzle("Login");
	}
}