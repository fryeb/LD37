using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	private bool m_Clicked = false;

	public bool clicked
	{
		get
		{
			return m_Clicked;
		}
		set
		{
			m_Clicked = value;
			if (m_Clicked)
			{
				SoundEffectController.Play("ButtonClick");
			}
		}
	}

	void OnDisable()
	{
		clicked = false;
	}
}
