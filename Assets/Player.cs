using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public Vector2 mouseSensitivity = Vector2.one;

	void Update()
	{
		transform.Rotate(0, Input.GetAxis("Mouse X") * mouseSensitivity.x, 0);
		Camera.main.transform.Rotate(Input.GetAxis("Mouse Y") * -mouseSensitivity.y, 0, 0);
	}
}
