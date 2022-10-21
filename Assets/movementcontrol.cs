using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementcontrol : MonoBehaviour
{
    public Transform girltorso;
    public Animator animator;
    Quaternion x  ;
   
    Rigidbody rb;
    [SerializeField] Transform markcenter; 
  void Start()
    {
        x = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);

        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
       
        /*xx =new Vector3(transform.position.x,transform.position.y,transform.position.z);*/


        if (Input.GetKeyDown("a"))
        {
           
                rb.AddForce(-200f, 0f, 0f);

        }
        if (Input.GetKeyDown("d"))
        {
            
            rb.AddForce(200f, 0f, 0f);

        }
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Soccer Tackle"))
        {
            transform.rotation = Quaternion.Euler(0transform.rotation.x, transform.position.y + 90,transform.position.z);
        }
        else
        {
            transform.rotation = x;
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
