using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
	private GameObject[] bullets;
	private float mouseClick;

	private void Start()
	{
		bullets = GameObject.FindGameObjectsWithTag("Bullets");
	}

	// Update is called once per frame
	private void Update()
	{
		MouseClicked();
	}

	private void MouseClicked()
	{
		if (Input.GetMouseButtonDown(0))
		{
			ReadInput();
		}
	}

	private void ReadInput()
	{
		mouseClick = Input.GetAxis("Fire1");
	}
}
