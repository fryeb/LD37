using UnityEngine;
using System.Collections;

public class Sky : MonoBehaviour {

	public string answer;

	private Button reset;
	private Textbox equation_1;

	void Start () 
	{
		reset = transform.FindChild("reset").GetComponent<Button>();
		equation_1 = transform.FindChild("equation_1").GetComponent<Textbox>();
	}

	void Update () 
	{
		if (equation_1.entered == answer)
		{

		}
	}
}
