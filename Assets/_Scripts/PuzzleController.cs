using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PuzzleController : MonoBehaviour {

	public string first;
	private static List<Transform> puzzles = new List<Transform>();

	void OnEnable()
	{
		for (int i = 0; i < transform.childCount; i++)
		{
			puzzles.Add(transform.GetChild(i));
		}
		LoadPuzzle(first);
	}

	public static void LoadPuzzle(string name)
	{
		foreach (var puzzle in puzzles)
		{
			if (puzzle.name == name)
				puzzle.gameObject.SetActive(true);
			else
				puzzle.gameObject.SetActive(false);
		}
	}

}
