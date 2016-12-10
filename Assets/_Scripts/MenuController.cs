using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public float TurnSpeed = 1.0f;

	private Transform SkyDome;

	void Start()
	{
		SkyDome = GameObject.Find("SkyDome").transform;
	}

	void Update()
	{
		SkyDome.Rotate(0f, TurnSpeed * Time.deltaTime, 0f);
	}

	void PlayNormal()
	{
		
	}

	void PlayZombies()
	{
		
	}

	void Quit()
	{
		Application.Quit();
	}
}
