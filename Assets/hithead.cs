using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hithead : MonoBehaviour
{
    [SerializeField] movingtodeath Movingtodeath;
    [SerializeField] GameObject player;
     Collider uppertorso ;
    public Animator animator;
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
        if (Input.GetKeyDown(KeyCode.Space))
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
        if (col.CompareTag("obstacleslide"))
        {
            
            Debug.Log("hit");

            animator.Play("fall");
            Movingtodeath.enabled = true;


        }
    }
}
