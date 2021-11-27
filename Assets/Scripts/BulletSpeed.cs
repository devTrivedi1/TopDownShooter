using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
	private Rigidbody bulletRB;
	[SerializeField]private GameObject playerBody;
	// Start is called before the first frame update
	void Start()
	{
		bulletRB = GetComponent<Rigidbody>();
		playerBody = GameObject.FindGameObjectWithTag("Player");
	}

	// Update is called once per frame
	void Update()
	{
		Speed();
		if (bulletRB.transform.position.z > 15)
		{
			Destroy(this.gameObject);
		}
	}

	void Speed()
	{
		float x = 0;
		float y = 0;
		bulletRB.velocity = new Vector3(playerBody.transform.rotation.y * 10, y, 10);
		bulletRB.rotation = Quaternion.Euler(0, playerBody.transform.position.y, 0);
	}
    
}
