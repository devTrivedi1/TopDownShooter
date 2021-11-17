using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	Vector3 mousePos;
	public Camera camera;
	void Start()
	{
		camera = Camera.main;
	}

	// Update is called once per frame
	void Update()
	{
        RotationHandle();
        PlayerRotation();
	}

	void RotationHandle()
	{
        mousePos = Input.mousePosition;
		Ray ray = camera.ScreenPointToRay(mousePos);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit))
		{
            mousePos = hit.point;
		}
	}
    void PlayerRotation()
    {
        Vector3 direction = this.mousePos - transform.position;
        direction.y = 0;
        transform.forward = direction;
    }
}
