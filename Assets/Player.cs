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

		Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));

		PointerEventData pointerData = new PointerEventData(EventSystem.current);

		pointerData.position = Input.mousePosition;

		List<RaycastResult> results = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerData, results);

		if (results.Count > 0)
		{
			if (results[0].gameObject.layer == LayerMask.NameToLayer("UI"))
			{
				string dbg = "Root Element: {0} \n GrandChild Element: {1}";
				Debug.Log(string.Format(dbg, results[results.Count - 1].gameObject.name, results[0].gameObject.name));
				results.Clear();
			}
		}
	}
}
