using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadsound : MonoBehaviour
{
    public int deadconfirm = 0;
     AudioSource playeraud;
    [SerializeField] AudioClip Dead;
    // Start is called before the first frame update
    void Start()
    {
        playeraud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (deadconfirm == 1 )
        {
            playeraud.clip = Dead;
            playeraud.Play();
        }
    }

   
   

}
