using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    private Rigidbody bulletRB;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Speed();
        if(bulletRB.transform.position.z > 15)
        {
            Destroy(this.gameObject);
        }
    }

    void Speed()
    {
        float x = 0;
        float y = 0;
        bulletRB.velocity = new Vector3(x, y, 10);
    }
}
