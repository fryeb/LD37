using UnityEngine;
using System.Collections;

public class Desktop : MonoBehaviour {

	public static bool sky_complete;
	public static bool grass_complete;
	public static bool roads_complete;
	public static bool buildings_complete;
	public static bool big_buildings_complete;
	public static bool life_complete;

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
		else if (grass.clicked && sky_complete)
			PuzzleController.LoadPuzzle("Grass");
		else if (roads.clicked && grass_complete)
			PuzzleController.LoadPuzzle("Roads");
		else if (buildings.clicked && roads_complete)
			PuzzleController.LoadPuzzle("Buildings");
		else if (bigBuildings.clicked && buildings_complete)
			PuzzleController.LoadPuzzle("Big Buildings");
		else if (life.clicked && big_buildings_complete)
			PuzzleController.LoadPuzzle("Life");
	}
}
