using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Textbox : MonoBehaviour {

	public string entered;

	private Text text;
	private string preamble;

	void Start () 
	{
		text = GetComponent<Text>();
		preamble = text.text;
		entered = "";
	}

	void OnDisable()
	{
		entered = "";
	}
	
	// Update is called once per frame
	void Update () {
		text.text = preamble + entered;

		if (entered.Length < 20)
		{
			if (Input.GetKeyDown(KeyCode.A))
				entered += "a";
			if (Input.GetKeyDown(KeyCode.B))
				entered += "b";
			if (Input.GetKeyDown(KeyCode.C))
				entered += "c";
			if (Input.GetKeyDown(KeyCode.D))
				entered += "d";
			if (Input.GetKeyDown(KeyCode.E))
				entered += "e";
			if (Input.GetKeyDown(KeyCode.F))
				entered += "f";
			if (Input.GetKeyDown(KeyCode.G))
				entered += "g";
			if (Input.GetKeyDown(KeyCode.H))
				entered += "h";
			if (Input.GetKeyDown(KeyCode.I))
				entered += "i";
			if (Input.GetKeyDown(KeyCode.J))
				entered += "j";
			if (Input.GetKeyDown(KeyCode.K))
				entered += "k";
			if (Input.GetKeyDown(KeyCode.L))
				entered += "l";
			if (Input.GetKeyDown(KeyCode.M))
				entered += "m";
			if (Input.GetKeyDown(KeyCode.N))
				entered += "n";
			if (Input.GetKeyDown(KeyCode.O))
				entered += "o";
			if (Input.GetKeyDown(KeyCode.P))
				entered += "p";
			if (Input.GetKeyDown(KeyCode.Q))
				entered += "q";
			if (Input.GetKeyDown(KeyCode.R))
				entered += "r";
			if (Input.GetKeyDown(KeyCode.S))
				entered += "s";
			if (Input.GetKeyDown(KeyCode.T))
				entered += "t";
			if (Input.GetKeyDown(KeyCode.U))
				entered += "u";
			if (Input.GetKeyDown(KeyCode.V))
				entered += "v";
			if (Input.GetKeyDown(KeyCode.W))
				entered += "w";
			if (Input.GetKeyDown(KeyCode.X))
				entered += "x";
			if (Input.GetKeyDown(KeyCode.Y))
				entered += "y";
			if (Input.GetKeyDown(KeyCode.Z))
				entered += "z";
			if (Input.GetKeyDown(KeyCode.Alpha0))
				entered += "0";
			if (Input.GetKeyDown(KeyCode.Alpha1))
				entered += "1";
			if (Input.GetKeyDown(KeyCode.Alpha2))
				entered += "2";
			if (Input.GetKeyDown(KeyCode.Alpha3))
				entered += "3";
			if (Input.GetKeyDown(KeyCode.Alpha4))
				entered += "4";
			if (Input.GetKeyDown(KeyCode.Alpha5))
				entered += "5";
			if (Input.GetKeyDown(KeyCode.Alpha6))
				entered += "6";
			if (Input.GetKeyDown(KeyCode.Alpha7))
				entered += "7";
			if (Input.GetKeyDown(KeyCode.Alpha8))
				entered += "8";
			if (Input.GetKeyDown(KeyCode.Alpha9))
				entered += "9";
			if (Input.GetKeyDown(KeyCode.Minus))
				entered += '-';
		}

		if (entered.Length > 0)
		{
			if (Input.GetKeyDown(KeyCode.Backspace))
				entered = entered.Substring(0, entered.Length - 1);
		}
	}
}
