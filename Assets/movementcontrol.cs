using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementcontrol : MonoBehaviour
{
    [SerializeField] screenappear endscreen;
    public int x = 0  ;
    [SerializeField] movingtodeath Movingtodeath;
    public Animator animator;
   // Collider player; 
   
    Rigidbody rb;
    [SerializeField] Transform markcenter; 
  void Start()
    {
        endscreen.enabled = false;
        Movingtodeath.enabled = false;
      /*  player = GetComponent<Collider>();
        player.enabled = false;*/
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        /*xx =new Vector3(transform.position.x,transform.position.y,transform.position.z);*/
        /*   if (Input.GetKeyDown(KeyCode.Space))
           {
               player.enabled = true;

           }*/
        if (Input.touchCount > 0)
        {   Touch touch = Input.GetTouch(0);
        if (Input.GetKeyDown("a") || touch.deltaPosition.x < -60)
        {

            rb.AddForce(-200f, 0f, 0f);

        }
        if (Input.GetKeyDown("d") || touch.deltaPosition.x > 60)
        {

            rb.AddForce(200f, 0f, 0f);

        }
    } 
        
        


        /* if(transform.position.y >= 2)
         {
             transform.position = new Vector3(transform.position.x, 2, transform.position.z);
         }*/









        if (Vector3.Distance(transform.position, markcenter.position) >= 1.1f /*|| transform.position.x == 0f*/ )
        {
            rb.velocity = new Vector3(0f, 0f, 0f);
            markcenter.position = transform.position;
        }
     
        if(transform.position.z <= -30f)
        {
            Destroy(gameObject);
        }
        if( x == 1) 
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (Input.GetKeyDown("w") || touch.deltaPosition.y > 30)
                {
                    rb.AddForce(0f, 300f, 0f);
                    x = 0;
                }

            }
        }
      if (transform.position.y <= -2f || transform.position.z < -23f) 
        {
            endscreen.enabled = true;
            Destroy(gameObject);
        
        }

    }

    void OnCollisionEnter(Collision col)
    {

            if(col.gameObject.CompareTag("ground"))
        {
            Debug.Log("on ground");
            x = 1;

        }
        
    }
}
