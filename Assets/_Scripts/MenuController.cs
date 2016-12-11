using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuController : MonoBehaviour
{

	public float TurnSpeed = 1.0f;

	private Transform SkyDome;
	private bool playNormal = false;
	private bool playZombies = false;
	private bool quit = false;

	void Awake()
	{
		SkyDome = GameObject.Find("SkyDome").transform;
		Cursor.visible = true;
	}

	void Update()
	{
		SkyDome.Rotate(0f, TurnSpeed * Time.deltaTime, 0f);

		if (ScreenFade.complete)
		{
			if (playNormal)
				SceneManager.LoadScene("Main", LoadSceneMode.Single);
			else if (playZombies)
				SceneManager.LoadScene("Menu", LoadSceneMode.Single);
			else if (quit)
				Application.Quit();
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