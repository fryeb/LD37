using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	void LateUpdate()
	{
		if (!ScreenFade.isBlack && ScreenFade.complete)
			ScreenFade.isBlack = true;
		else if (ScreenFade.isBlack && ScreenFade.complete)
			SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}
}
