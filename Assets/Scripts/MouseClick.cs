using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
	[SerializeField] private GameObject bulletPrefab;
	private float mouseClick;

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

		Instantiate(bulletPrefab, this.transform.position, Quaternion.Euler(new Vector3(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z)));
	}

}
