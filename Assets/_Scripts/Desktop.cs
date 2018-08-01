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
		sky = transform.Find("Sky").GetComponent<Button>();
		grass = transform.Find("Grass").GetComponent<Button>();
		roads = transform.Find("Roads").GetComponent<Button>();
		buildings = transform.Find("Buildings").GetComponent<Button>();
		skyscrapers = transform.Find("Skyscrapers").GetComponent<Button>();
		life = transform.Find("Life").GetComponent<Button>();

		sky_complete = false;
		grass_complete = false;
		roads_complete = false;
		buildings_complete = false;
		skyscrapers_complete = false;
		life_complete = false;
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

		sky.transform.Find("Incomplete").gameObject.SetActive(true);

		if (sky_complete)
		{
			sky.transform.Find("Complete").gameObject.SetActive(true);
			grass.transform.Find("Incomplete").gameObject.SetActive(true);
		}
		if (grass_complete)
		{
			grass.transform.Find("Complete").gameObject.SetActive(true);
			roads.transform.Find("Incomplete").gameObject.SetActive(true);
		}
		if (roads_complete)
		{
			roads.transform.Find("Complete").gameObject.SetActive(true);
			buildings.transform.Find("Incomplete").gameObject.SetActive(true);
		}
		if (buildings_complete)
		{
			buildings.transform.Find("Complete").gameObject.SetActive(true);
			skyscrapers.transform.Find("Incomplete").gameObject.SetActive(true);
		}
		if (skyscrapers_complete)
		{
			skyscrapers.transform.Find("Complete").gameObject.SetActive(true);
			life.transform.Find("Incomplete").gameObject.SetActive(true);
		}
		if (life_complete)
		{
			life.transform.Find("Complete").gameObject.SetActive(true);
		}
	}
}
