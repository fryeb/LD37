using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour
{

	public float TurnSpeed = 1.0f;

	private Transform SkyDome;
	private bool playNormal = false;
	private bool playZombies = false;
	private bool quit = false;

	void Start()
	{
		SkyDome = GameObject.Find("SkyDome").transform;
	}

	void Update()
	{
		SkyDome.Rotate(0f, TurnSpeed * Time.deltaTime, 0f);

		if (ScreenFade.complete)
		{
			if (playNormal)
				Debug.Log("Play Normal");
			else if (playZombies)
				Debug.Log("Play Zombies");
			else if (quit)
				Debug.Log("Quit");
		}
	}

	public void PlayNormal()
	{
		playNormal = true;
		ScreenFade.isBlack = true;
	}

	public void PlayZombies()
	{
		playZombies = true;
		ScreenFade.isBlack = true;
	}

	public void Quit()
	{
		quit = true;
		ScreenFade.isBlack = true;
	}
}