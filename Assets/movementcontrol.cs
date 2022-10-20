using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementcontrol : MonoBehaviour
{
    public Animator animator;
   
    Rigidbody rb;
    [SerializeField] Transform markcenter; 
  void Start()
    {
        
       
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
        

        if (Input.GetKeyDown("a"))
        {
           
                rb.AddForce(-200f, 0f, 0f);

        }
        if (Input.GetKeyDown("d"))
        {
            
            rb.AddForce(200f, 0f, 0f);

        }

        if (Vector3.Distance(transform.position, markcenter.position) >= 1.1f /*|| transform.position.x == 0f*/ )
        {
            rb.velocity = new Vector3(0f, 0f, 0f);
            markcenter.position = transform.position;
        }
     




    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("obstacle"))
        {
            rb.velocity = new Vector3(0f, 0f, -25f);
            Debug.Log("hit");
           
            animator.Play("fall");
           

        }
    }
}
