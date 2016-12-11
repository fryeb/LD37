using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScreenFade : MonoBehaviour {

	public float duration = 1.0f;

	public static bool complete
	{
		get
		{
			return (alpha >= 1.0f || alpha <= 0.0f);
		}
	}

	private Image black;
	public static bool isBlack = false;
	private static float alpha = 1.0f;

	void Start () 
	{
		black = transform.FindChild("black").GetComponent<Image>();
	}

	void Update () 
	{
		if (!isBlack && alpha > 0)
		{
			alpha -= Time.deltaTime / duration;
		}
		else if (isBlack && alpha < 1.0f)
		{
			alpha += Time.deltaTime / duration;
		}

		black.color = new Color(0.0f, 0.0f, 0.0f, alpha);
	}
}
