using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MusicController : MonoBehaviour {

	public string start = "ThemeMain";
	private static List<GameObject> Music = new List<GameObject>();

	void Awake () 
	{
		Music.Clear();
		for (int i = 0; i < transform.childCount; i++)
		{
			Music.Add(transform.GetChild(i).gameObject);
			Music[i].SetActive(false);
		}

		Play(start);
	}

	public static void Play(string name)
	{
		foreach (GameObject song in Music)
		{
			if (song.name == name)
				song.SetActive(true);
			else
				song.SetActive(false);
		}
	}
}
