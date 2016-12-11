using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundEffectController : MonoBehaviour
{
	private static List<AudioSource> Effects = new List<AudioSource>();

	void Awake()
	{
		Effects.Clear();
		for (int i = 0; i < transform.childCount; i++)
		{
			Effects.Add(transform.GetChild(i).GetComponent<AudioSource>());
		}
	}


	public static void Play(string name)
	{
		foreach (AudioSource effect in Effects)
		{
			if (effect.name == name)
				effect.Play();
		}
	}
}