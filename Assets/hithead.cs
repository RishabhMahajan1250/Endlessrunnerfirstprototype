using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hithead : MonoBehaviour
{
   
    static int x;
    public int score = 0;
    [SerializeField] movingtodeath Movingtodeath;
    [SerializeField] GameObject player;
     Collider uppertorso ;
    public Animator animator;
    [SerializeField] AudioSource playeraud;
    [SerializeField] AudioClip coincollected;
    [SerializeField] AudioClip running;
    // Start is called before the first frame update
    void Start()
    {
        Movingtodeath.enabled = false;
        uppertorso = GetComponent<Collider>();
        uppertorso.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            x = 2;
        }
        if(x == 2)
        {
            uppertorso.enabled = true;
        }


        if (player.transform.position.z <= -30f)
        {
            Destroy(player);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("obstacleslide") || col.CompareTag("obstacle"))
        {
            
            Debug.Log("hit");
           
            animator.Play("fall");
            Movingtodeath.enabled = true;


        }
        if (col.CompareTag("coin"))
        {
           
            playeraud.clip = coincollected;
            playeraud.Play();
            Destroy(col.gameObject);
            score++;

        }
        /*else if(animator.GetCurrentAnimatorStateInfo(0).IsName("mixamo_com"))
        {
           
            playeraud.clip = running;
            playeraud.Play();
        }*/
      
    }
    
}
