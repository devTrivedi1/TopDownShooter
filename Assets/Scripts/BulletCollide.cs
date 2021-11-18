using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollide : MonoBehaviour
{
	private GameObject enemy;
	void Update()
	{
		enemy = GameObject.FindGameObjectWithTag("Enemies");
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Enemies")
		{
			Destroy(enemy);
			Destroy(this.gameObject);
		}
	}
}
