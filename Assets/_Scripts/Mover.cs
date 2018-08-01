using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Mover : MonoBehaviour {

	public float fillPerSecond = 1.0f;
	public bool moving = true;

	public float fill
	{
		get
		{
			return image.fillAmount;
		}
	}

	private bool fillDirection = true;
	private Image image;

	void Start () 
	{
		image = transform.Find("Image").GetComponent<Image>();
	}

	void Update () 
	{
		if (moving)
		{
			if (fillDirection)
			{
				image.fillAmount += fillPerSecond * Time.deltaTime;
				if (image.fillAmount >= 1.0f)
					fillDirection = false;
			}
			else
			{
				image.fillAmount -= fillPerSecond * Time.deltaTime;
				if (image.fillAmount <= 0.0f)
					fillDirection = true;
			}
		}
	}
}
