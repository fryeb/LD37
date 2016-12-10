﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WorldController : MonoBehaviour {
	
	private static List<Transform> elements = new List<Transform>();

	void Awake()
	{
		for (int i = 0; i < transform.childCount; i++)
		{
			elements.Add(transform.GetChild(i));
			elements[i].gameObject.SetActive(false);
		}
	}

	public static void UnlockElement(string name)
	{
		foreach (var element in elements)
		{
			if (element.name == name)
			{
				element.gameObject.SetActive(true);
			};
		}
	}

}