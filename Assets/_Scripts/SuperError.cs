using UnityEngine;
using System.Collections;

public class SuperError : MonoBehaviour {

	public float delay = 1.0f;

	private float elapsed = 1.0f;
	private int currentChild = 0;

	void Start()
	{
		for (int i = 0; i < transform.childCount; i++)
		{
			transform.GetChild(i).gameObject.SetActive(false);
		};
	}

	void Update () 
	{
		if (currentChild < transform.childCount)
		{
			elapsed += Time.deltaTime;

			if (elapsed >= delay)
			{
				transform.GetChild(currentChild).gameObject.SetActive(true);
				elapsed = 0.0f;
				currentChild++;
			}
		}
	}
}
