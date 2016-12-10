using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
public class Player : MonoBehaviour
{
	public Vector2 mouseSensitivity = Vector2.one;

	void Update()
	{
		Vector2 look = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0f);
		transform.Rotate(0, look.x * mouseSensitivity.x, 0);
		Camera.main.transform.Rotate(look.y * -mouseSensitivity.y, 0, 0);

		if (Input.GetMouseButton(0))
		{
			PointerEventData pointerData = new PointerEventData(EventSystem.current);
			pointerData.position = new Vector3(Screen.width / 2, Screen.height / 2);

			List<RaycastResult> results = new List<RaycastResult>();
			EventSystem.current.RaycastAll(pointerData, results);

			foreach (RaycastResult result in results)
			{
				if (result.gameObject.layer == LayerMask.NameToLayer("WorldUI"))
				{
					Debug.Log(result.gameObject.name);
			}
		}
		}
	}
}
