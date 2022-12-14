using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
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
        player_Animator.Play("mixamo_com 1");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) || player_Animator.GetCurrentAnimatorStateInfo(0).IsName("mixamo_com 1"))
        {
            player_Animator.Play("mixamo_com");
            audioSource.clip = running;
            audioSource.Play();
        }


        /*   if (Input.GetKeyDown(KeyCode.Space))
           {
               player_Animator.Play("mixamo_com");
           }*/
        if (Input.GetKeyDown("s"))
        {
            player_Animator.Play("Soccer Tackle");
            audioSource.clip = slide;
            audioSource.Play();

        }
        if (Input.GetKeyDown("w"))
        {
            player_Animator.Play("Jump");
            audioSource.clip = jump;
            audioSource.Play();
        }
     

    }
}
