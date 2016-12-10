using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public bool clicked = false;

	void OnDisable()
	{
		clicked = false;
	}
}
