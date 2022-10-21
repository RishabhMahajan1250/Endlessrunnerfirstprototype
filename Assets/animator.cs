using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    [SerializeField] Collider player;
    Animator player_Animator;
    // Start is called before the first frame update
    void Start()
    {

        
        player_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) || player_Animator.GetCurrentAnimatorStateInfo(0).IsName("mixamo_com 1"))
        {
            player_Animator.Play("mixamo_com");
        }


        /*   if (Input.GetKeyDown(KeyCode.Space))
           {
               player_Animator.Play("mixamo_com");
           }*/
        if (Input.GetKeyDown("s"))
        {
            player_Animator.Play("Soccer Tackle");
        }
       

           
    }
}
