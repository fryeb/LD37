using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Mover : MonoBehaviour {

	public float fillPerSecond = 1.0f;

	public float fill
	{
		get
		{
			return image.fillAmount;
		}
	}

	private float fillSpeed;
	private bool fillDirection = true;
	private Image image;

	void Start () 
	{
		image = transform.FindChild("Image").GetComponent<Image>();
		fillSpeed = 1 / fillPerSecond;
	}

	void Update () 
	{
		if (fillDirection)
		{
			image.fillAmount += fillSpeed * Time.deltaTime;
			if (image.fillAmount >= 1.0f)
				fillDirection = false;
		}
		else
		{
			image.fillAmount -= fillSpeed * Time.deltaTime;
			if (image.fillAmount <= 0.0f)
				fillDirection = true;
		}

		Debug.Log(fill);
	}
}
