using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.position += new Vector3(0f, 0f, -20f * Time.deltaTime * speed);
        if (transform.position.z <= -21.9f)
        {
            Destroy(gameObject);
        }
    }
}
