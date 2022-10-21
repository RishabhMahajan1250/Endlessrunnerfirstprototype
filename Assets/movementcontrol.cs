using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementcontrol : MonoBehaviour
{
    [SerializeField] movingtodeath Movingtodeath;
    public Animator animator;
    Collider player; 
   
    Rigidbody rb;
    [SerializeField] Transform markcenter; 
  void Start()
    {
        
        Movingtodeath.enabled = false;
        player = GetComponent<Collider>();
        player.enabled = false;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        /*xx =new Vector3(transform.position.x,transform.position.y,transform.position.z);*/
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.enabled = true;
        }
    if(player.enabled == true){ 
        if (Input.GetKeyDown("a"))
        {

            rb.AddForce(-200f, 0f, 0f);

        }
        if (Input.GetKeyDown("d"))
        {

            rb.AddForce(200f, 0f, 0f);

        }

        if (Input.GetKeyDown("w"))
        {
                rb.AddForce(0f, 500f, 0f);
        }

    }
      
     

        if (Vector3.Distance(transform.position, markcenter.position) >= 1.1f /*|| transform.position.x == 0f*/ )
        {
            rb.velocity = new Vector3(0f, 0f, 0f);
            markcenter.position = transform.position;
        }
     
        if(transform.position.z <= -30f)
        {
            Destroy(gameObject);
        }



    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("obstacle"))
        {
            //rb.velocity = new Vector3(0f, 0f, -25f);
            Debug.Log("hit");
           
            animator.Play("fall");
            Movingtodeath.enabled = true;

        }
    }
}
