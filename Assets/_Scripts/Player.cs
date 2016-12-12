using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
	public Vector2 mouseSensitivity = Vector2.one;

	void Awake()
	{
		Cursor.visible = false;
	}


	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
			ScreenFade.isBlack = true;

		Vector2 look = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0f);
		transform.Rotate(0, look.x * mouseSensitivity.x, 0);
		Camera.main.transform.Rotate(look.y * -mouseSensitivity.y, 0, 0);

		if (Input.GetMouseButtonDown(0))
		{
			PointerEventData pointerData = new PointerEventData(EventSystem.current);
			pointerData.position = new Vector3(Screen.width / 2, Screen.height / 2);

			List<RaycastResult> results = new List<RaycastResult>();
			EventSystem.current.RaycastAll(pointerData, results);

			foreach (RaycastResult result in results)
			{
				Button button = result.gameObject.GetComponent<Button>();
				if (button != null)
				{
					button.clicked = true;
				}
			}
		}
	}

	void LateUpdate()
	{
		if (ScreenFade.isBlack && ScreenFade.complete)
			SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}
}
