using UnityEngine;
using System.Collections;

public class Error : MonoBehaviour {

	private Button ButtonX;
	private Button ButtonOK;

	void Start () 
	{
		ButtonX = transform.Find("ButtonX").GetComponent<Button>();
		ButtonOK = transform.Find("ButtonOK").GetComponent<Button>();

	}

	void Update () 
	{
		if (ButtonX.clicked || ButtonOK.clicked)
			PuzzleController.LoadPuzzle("Logo");
	}
}
