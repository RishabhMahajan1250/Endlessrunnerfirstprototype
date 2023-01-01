using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    static int x = 0;
    AudioSource audioSource;
    [SerializeField] AudioClip running;
    [SerializeField] AudioClip jump;
    [SerializeField] AudioClip slide;
    Animator player_Animator;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player_Animator = GetComponent<Animator>();
        player_Animator.Play("mixamo_com");
        audioSource.clip = running;
        audioSource.loop = true;
        audioSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
            
       
   
  








        if (Input.touchCount > 0 )
        {
            Touch touch = Input.GetTouch(0);

           
            


            /*   if (Input.GetKeyDown(KeyCode.Space))
               {
                   player_Animator.Play("mixamo_com");
               }*/
            if (Input.GetKeyDown("s") || touch.deltaPosition.y  < -30)
            {
                player_Animator.Play("Soccer Tackle");
                x = 0;
                if (player_Animator.GetCurrentAnimatorStateInfo(0).IsName("Soccer Tackle"))
                {
                    audioSource.clip = slide;
                    audioSource.loop = false;
                    audioSource.Play();
                }
                if (player_Animator.GetCurrentAnimatorStateInfo(0).IsName("mixamo_com"))
                {
                    audioSource.clip = running;
                    audioSource.loop = true;
                    audioSource.Play();
                }

            }
       /*     else
        if (player_Animator.GetCurrentAnimatorStateInfo(0).IsName("mixamo_com"))
            {
                
                audioSource.loop = true;
                audioSource.clip = running;
                audioSource.Play();
            }*/
            if (Input.GetKeyDown("w") || touch.deltaPosition.y > 30)
            {
                player_Animator.Play("Jump");
                x = 0;
                if (player_Animator.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
                {
                    audioSource.clip = jump;
                    audioSource.loop = false;
                    audioSource.Play();
                }
                if(player_Animator.GetCurrentAnimatorStateInfo(0).IsName("mixamo_com"))
                {
                    audioSource.clip = running;
                    audioSource.loop = true;
                    audioSource.Play();
                }

            }
    /*        else
        if (player_Animator.GetCurrentAnimatorStateInfo(0).IsName("mixamo_com"))
            {
             
                audioSource.loop = true;
                audioSource.clip = running;
                audioSource.Play();
            }*/

        }

      
      
    }
}
