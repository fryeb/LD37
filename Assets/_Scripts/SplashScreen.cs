using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	private int shown = 0;

	void Awake()
	{
		UpdateChilderen();
	}


	void LateUpdate()
	{
		if (!ScreenFade.isBlack && ScreenFade.complete)
		{
			ScreenFade.isBlack = true;
			shown++;
		}
		else if (ScreenFade.isBlack && ScreenFade.complete)
		{
			if (shown < (transform.childCount - 1))
				UpdateChilderen();
			else
				SceneManager.LoadScene("Menu", LoadSceneMode.Single);
		}
	}

	void UpdateChilderen()
	{
		for (int i = 0; i < (transform.childCount - 1); i++)
		{
			transform.GetChild(i).gameObject.SetActive(false);
		};

		transform.GetChild(shown).gameObject.SetActive(true);
		ScreenFade.isBlack = false;
	}
}
