using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SuperError : MonoBehaviour {


	public float duration = 15.0f;
	public float delay = 1.0f;

	private float elapsed = 1.0f;
	private int currentChild = 0;

	void Awake()
	{
		for (int i = 0; i < transform.childCount; i++)
		{
			transform.GetChild(i).gameObject.SetActive(false);
		};

		MusicController.Play("ThemeError");
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

		duration -= Time.deltaTime;
		if (duration <= 0.0f)
		{
			ScreenFade.isBlack = true;
		}
	}
}
