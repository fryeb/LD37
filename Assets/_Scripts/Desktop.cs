using UnityEngine;
using System.Collections;

public class Desktop : MonoBehaviour {

	public static bool sky_complete;
	public static bool grass_complete;
	public static bool roads_complete;
	public static bool buildings_complete;
	public static bool skyscrapers_complete;
	public static bool life_complete;

	private Button sky;
	private Button grass;
	private Button roads;
	private Button buildings;
	private Button skyscrapers;
	private Button life;

	void Awake () 
	{
		sky = transform.FindChild("Sky").GetComponent<Button>();
		grass = transform.FindChild("Grass").GetComponent<Button>();
		roads = transform.FindChild("Roads").GetComponent<Button>();
		buildings = transform.FindChild("Buildings").GetComponent<Button>();
		skyscrapers = transform.FindChild("Skyscrapers").GetComponent<Button>();
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
		else if (skyscrapers.clicked && buildings_complete)
			PuzzleController.LoadPuzzle("Skyscrapers");
		else if (life.clicked && skyscrapers_complete)
			PuzzleController.LoadPuzzle("Life");

		sky.transform.FindChild("Incomplete").gameObject.SetActive(true);

		if (sky_complete)
		{
			sky.transform.FindChild("Complete").gameObject.SetActive(true);
			grass.transform.FindChild("Incomplete").gameObject.SetActive(true);
		}
		if (grass_complete)
		{
			grass.transform.FindChild("Complete").gameObject.SetActive(true);
			roads.transform.FindChild("Incomplete").gameObject.SetActive(true);
		}
		if (roads_complete)
		{
			roads.transform.FindChild("Complete").gameObject.SetActive(true);
			buildings.transform.FindChild("Incomplete").gameObject.SetActive(true);
		}
		if (buildings_complete)
		{
			buildings.transform.FindChild("Complete").gameObject.SetActive(true);
			skyscrapers.transform.FindChild("Incomplete").gameObject.SetActive(true);
		}
		if (skyscrapers_complete)
		{
			skyscrapers.transform.FindChild("Complete").gameObject.SetActive(true);
			life.transform.FindChild("Incomplete").gameObject.SetActive(true);
		}
		if (life_complete)
		{
			life.transform.FindChild("Complete").gameObject.SetActive(true);
		}
	}
}
