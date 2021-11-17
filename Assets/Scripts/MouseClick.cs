using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
	private GameObject bullets;
	private float speed = 10f;
	private float mouseClick;

	private void Start()
	{
		bullets = (GameObject)Instantiate(bullets, transform.position, Quaternion.identity);
		bullets.tag = "Bullets";
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
			Shoot();
		}
	}

	private void ReadInput()
	{
		mouseClick = Input.GetAxis("Fire1");
	}

	private void Shoot()
	{
		bullets = Instantiate(bullets, transform.position, Quaternion.identity);
	}
}
