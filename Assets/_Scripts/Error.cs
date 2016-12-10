using UnityEngine;
using System.Collections;

public class Error : MonoBehaviour {

	private Button ButtonX;
	private Button ButtonOK;

	void Start () 
	{
		ButtonX = transform.FindChild("ButtonX").GetComponent<Button>();
		ButtonOK = transform.FindChild("ButtonOK").GetComponent<Button>();

	}

	void Update () 
	{
		if (ButtonX.clicked || ButtonOK.clicked)
			PuzzleController.LoadPuzzle("Logo");
	}
}
