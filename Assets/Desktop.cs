using UnityEngine;
using System.Collections;

public class Desktop : MonoBehaviour {

	private Button sky;
	private Button grass;
	private Button roads;
	private Button buildings;
	private Button bigBuildings;
	private Button life;

	void Start () 
	{
		sky = transform.FindChild("Sky").GetComponent<Button>();
		grass = transform.FindChild("Grass").GetComponent<Button>();
		roads = transform.FindChild("Roads").GetComponent<Button>();
		buildings = transform.FindChild("Buildings").GetComponent<Button>();
		bigBuildings = transform.FindChild("Big Buildings").GetComponent<Button>();
		life = transform.FindChild("Life").GetComponent<Button>();
	}

	void Update () 
	{
		if (sky.clicked)
			PuzzleController.LoadPuzzle("Sky");
		else if (grass.clicked)
			PuzzleController.LoadPuzzle("Grass");
		else if (roads.clicked)
			PuzzleController.LoadPuzzle("Roads");
		else if (buildings.clicked)
			PuzzleController.LoadPuzzle("Buildings");
		else if (bigBuildings.clicked)
			PuzzleController.LoadPuzzle("Big Buildings");
		else if (life.clicked)
			PuzzleController.LoadPuzzle("Life");
	}
}
