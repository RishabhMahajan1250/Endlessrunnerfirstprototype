using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startonspace : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
            rb.useGravity = true;
        }
    }
}
